using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using System.Security.Claims;
using LightAndLens.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net;



namespace LightAndLens.WebApp.Controllers
{
    public class RentalRequestsController : Controller
    {
        private readonly LightAndLensDBContext _context;
        private readonly Services.LogHelper _logHelper;
        public RentalRequestsController(LightAndLensDBContext context, Services.LogHelper logHelper)
        {
            _context = context;
            _logHelper = logHelper;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Admin") || User.IsInRole("Staff"))
            {
                // Redirect admins and staff to their management view
                return RedirectToAction("AdminView");
            }
            else
            {
                // Redirect customers to their own requests view
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                return RedirectToAction("CustomerView", new { userId = userId });
            }
        }



        // Admin action - show all rental requests with filtering etc.
        [Authorize(Roles = "Admin,Staff")]  // restrict access
        public IActionResult AdminView(string search, int? status)
        {
            var query = _context.RentalRequests
                .Include(r => r.User)
                .Include(r => r.Equipment)
                .Include(r => r.RequestStatus)
                .AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(r =>
                    r.User.Email.Contains(search) ||
                    r.Equipment.EquipmentName.Contains(search) ||
                    r.User.FullName.Contains(search));
            }

            if (status.HasValue)
            {
                query = query.Where(r => r.RequestStatusId == status.Value);
            }

            var model = new AdminViewModel
            {
                RentalRequests = query.ToList(),
                Search = search,
                Status = status
            };

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Staff")]
        public IActionResult UpdateRequestStatus(int id, int status)
        {
            var request = _context.RentalRequests.Find(id);
            if (request == null)
            {
                return NotFound();
            }

            request.RequestStatusId = status;
            _context.SaveChanges();


            //creating rental transaction
            var rentalRequest = _context.RentalRequests.Find(id);
            var equipment = _context.Equipment.Find(rentalRequest.EquipmentId);
            var rentalDays = (rentalRequest.RequestEndDate - rentalRequest.RequestStartDate).Days;
            var equipmentRentalFee = equipment.RentalPricePerDay * rentalDays;

            var rentalTransaction = new RentalTransaction
            {
                UserId = rentalRequest.UserId,
                StartDate = rentalRequest.RequestStartDate,
                EndDate = rentalRequest.RequestEndDate,
                RentalFee = equipmentRentalFee,
                DepositPaid = 0,
                Status = "Ongoing",
                RequestId = rentalRequest.RequestId
            };


            _context.RentalTransactions.Add(rentalTransaction);
            _context.SaveChanges();


            //creating a notification for the user
            var notification = new Notification
            {
                UserId = rentalRequest.UserId,
                Message = status == 1 ? $"Your rental request with the id#{rentalRequest.RequestId} has been approved." : $"Your rental request  with the id#{rentalRequest.RequestId} has been rejected.",
                Type = status == 1 ? "Success" : "Rejected",
                IsRead = false
            };

            _context.Notifications.Add(notification);
            _context.SaveChanges();


            // Set a TempData message to display after redirect
            TempData["StatusMessage"] = status == 2 ? "Request approved successfully." : "Request rejected successfully.";

            return RedirectToAction("AdminView");
        }





        [HttpGet]
        public IActionResult RentItem()
        {
            var availableEquipment = _context.Equipment
                .Where(e => e.AvailabilityId == 1) // available items only
                .ToList();

            return View(availableEquipment); // or use a ViewModel if needed
        }


        // Customer action - show only requests for logged-in user
        public IActionResult CustomerView(int? status)
        {
            string identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.FirstOrDefault(u => u.IdentityUserId == identityUserId);
            if (user == null)
                return Unauthorized();

            int userId = user.UserId;

            var query = _context.RentalRequests
                .Where(r => r.UserId == userId)
                .Include(r => r.Equipment)
                .Include(r => r.RequestStatus)
                .AsQueryable();

            // Apply status filter if specified
            if (status.HasValue)
            {
                query = query.Where(r => r.RequestStatusId == status.Value);
            }

            var filteredRequests = query.ToList();

            var availableEquipment = _context.Equipment
                .Where(e => e.Quantity > 0)
                .ToList();

            var viewModel = new CustomerViewModel
            {
                PendingRequests = filteredRequests,
                AvailableEquipment = availableEquipment,
                Status = status
            };

            return View(viewModel);
        }




        public IActionResult CreateRentalRequest()
        {
            var availableEquipment = _context.Equipment.ToList(); // Get available equipment from the database
            ViewData["AvailableEquipment"] = availableEquipment; // Pass equipment list to the view
            return View();
        }

        [HttpPost]
        public IActionResult CreateRentalRequest(string EquipmentID, DateTime RequestStartDate, DateTime RequestEndDate)
        {
            string identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = _context.Users.FirstOrDefault(u => u.IdentityUserId == identityUserId);

            if (user == null)
            {
                return Unauthorized(); // user not found in your DB
            }

            int userId = user.UserId;

            if (int.TryParse(EquipmentID, out int equipmentId))
            {
                var rentalRequest = new RentalRequest
                {
                    UserId = userId,
                    EquipmentId = equipmentId,
                    RequestStartDate = RequestStartDate,
                    RequestEndDate = RequestEndDate,
                    RequestStatusId = 1,
                    RequestSetDate = DateTime.Now
                };

                _context.RentalRequests.Add(rentalRequest);
                _context.SaveChanges();

                return RedirectToAction("Index"); // Redirect to a list of rental requests or some other page
            }
            else
            {
                // Handle the case when the conversion fails (e.g., show an error message)
                ModelState.AddModelError("EquipmentID", "Invalid equipment selection.");
                return View(); // Return to the form view
            }
        }


        [HttpPost]
        public IActionResult Create(int EquipmentId, DateTime RequestStartDate, DateTime RequestEndDate)
        {
            string identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users.FirstOrDefault(u => u.IdentityUserId == identityUserId);

            if (user == null)
                return Unauthorized();

            int userId = user.UserId;

            var newRequest = new RentalRequest
            {
                UserId = userId,
                EquipmentId = EquipmentId,
                RequestStartDate = RequestStartDate,
                RequestEndDate = RequestEndDate,
                RequestStatusId = 2,  // by default the status of the request will be pending 
                RequestSetDate = DateTime.Now
            };

            _context.RentalRequests.Add(newRequest);
            _context.SaveChanges();


            // Redirect back to CustomerView so that pending requests reload with the new request included
            return RedirectToAction("CustomerView");
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();

            var rentalRequest = _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.RequestStatus)
                .Include(r => r.User)
                .FirstOrDefault(r => r.RequestId == id);

            if (rentalRequest == null)
                return NotFound();

            // Fetch the image path related to the equipment
            var equipmentImage = _context.EquipmentImages
                .Where(img => img.EquipmentId == rentalRequest.EquipmentId)
                .Select(img => img.ImagePath)
                .FirstOrDefault();

            var vm = new RentalRequestViewModel
            {
                RequestId = rentalRequest.RequestId,
                EquipmentId = rentalRequest.EquipmentId,
                RequestStartDate = rentalRequest.RequestStartDate,
                RequestEndDate = rentalRequest.RequestEndDate,
                RequestSetDate = rentalRequest.RequestSetDate,
                EquipmentName = rentalRequest.Equipment?.EquipmentName,
                StatusName = rentalRequest.RequestStatus?.StatusName,
                UserEmail = rentalRequest.User?.Email,
                EquipmentImagePath = equipmentImage // can be null if not found
            };

            return View(vm);
        }


        // GET: RentalRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.RequestStatus)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RequestId == id);

            if (rentalRequest == null)
            {
                return NotFound();
            }

            return View(rentalRequest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var rentalRequest = await _context.RentalRequests.FindAsync(id);
            if (rentalRequest != null)
            {
                _context.RentalRequests.Remove(rentalRequest);
                await _context.SaveChangesAsync();

                TempData["StatusMessage"] = "Your rental request was successfully cancelled.";
            }
            else
            {
                TempData["StatusMessage"] = "Rental request not found.";
            }
            return RedirectToAction(nameof(CustomerView)); // Or your appropriate action
        }








    }
}
