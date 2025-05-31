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
using System.Reflection;



namespace LightAndLens.WebApp.Controllers
{
    [Authorize]
    public class RentalRequestsController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public RentalRequestsController(LightAndLensDBContext context)
        {
            _context = context;
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

            //show the rental requests by descending date
            query = query.OrderByDescending(r => r.RequestSetDate);

            var availableEquipment = _context.Equipment
             .Where(e => e.Quantity > 0 && e.AvailabilityId == 1)
             .ToList();

            var model = new AdminViewModel
            {
                AvailableEquipment = availableEquipment,
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

            //if the request is rejected the equipment quantity will be increased by 1 && update the availability status to available
            if (request.RequestStatusId == 3)
            {
                var requestEquipment = _context.Equipment.Find(request.EquipmentId);
                requestEquipment.Quantity += 1;
                requestEquipment.AvailabilityId = 1;
                _context.SaveChanges();
            }

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


            //getting the current methiod name for notification logic method
            var methodName = MethodBase.GetCurrentMethod().Name;
            notificationLogic(id, status, methodName);


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

            return View(availableEquipment);
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

            if (status.HasValue)
            {
                query = query.Where(r => r.RequestStatusId == status.Value);
            }

            //show the rental requests by descending date
            query = query.OrderByDescending(r => r.RequestSetDate);

            var availableEquipment = _context.Equipment
                .Where(e => e.Quantity > 0 && e.AvailabilityId == 1)
                .ToList();

            var viewModel = new CustomerViewModel
            {
                PendingRequests = query.ToList(),
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
        public IActionResult Create(int EquipmentId, DateTime RequestStartDate, DateTime RequestEndDate)
        {
            string identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _context.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.IdentityUserId == identityUserId);

            if (user == null)
                return Unauthorized();

            int userId = user.UserId;

            var equipment = _context.Equipment.Find(EquipmentId);
            if (equipment == null)
            {
                ModelState.AddModelError("EquipmentId", "Selected equipment does not exist.");
                return View(); // Return to the form view with an error
            }
            else
            {
                // Check if the equipment is available (AvailabilityId == 1)
                if (equipment.AvailabilityId == 1)
                {
                    if (equipment.Quantity >= 1)
                    {
                        // Decrease quantity
                        equipment.Quantity -= 1;

                        // If quantity reaches 0, mark as unavailable
                        if (equipment.Quantity == 0)
                        {
                            equipment.AvailabilityId = 2;
                        }

                        _context.SaveChanges(); // Save changes
                    }
                    else
                    {
                        ModelState.AddModelError("Quantity", "Equipment is out of stock.");
                        return View(); // Return to form with error
                    }
                }
                else
                {
                    ModelState.AddModelError("Availability", "This equipment is currently unavailable.");
                    return View(); // Return to form with error
                }
            }

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



            //send notification to the admin and staff
            var methodName = MethodBase.GetCurrentMethod().Name;
            notificationLogic(newRequest.RequestId, newRequest.RequestStatusId, methodName);


            // Redirect based on user role
            var roleName = user.Role.RoleName?.ToLower();

            if (roleName == "admin" || roleName == "staff")
            {
                return RedirectToAction("AdminView", "RentalRequests");
            }else
            {
                return RedirectToAction("CustomerView", "RentalRequests");
            }

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
                EquipmentImagePath = equipmentImage
            };

            return View(vm);
        }


        // GET: RentalRequests/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var rentalRequest = await _context.RentalRequests
        //        .Include(r => r.Equipment)
        //        .Include(r => r.RequestStatus)
        //        .Include(r => r.User)
        //        .FirstOrDefaultAsync(m => m.RequestId == id);

        //    if (rentalRequest == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(rentalRequest);
        //}

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


        public void notificationLogic(int id, int status, string method)
        {

            var rentalRequest = _context.RentalRequests.Find(id);

            if (method == "UpdateRequestStatus")
            {
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
            }


            //creating a notification for the admin && staff
            if (method == "Create")
            {

                // Get all users with role Admin or Staff
                var adminStaffUsers = _context.Users
                    .Include(u => u.Role)
                    .Where(u => u.Role.RoleName == "Admin" || u.Role.RoleName == "Staff")
                    .ToList();

                //creating notifications for each admin and staff user
                foreach (var user in adminStaffUsers)
                {
                    var notification = new Notification
                    {
                        UserId = user.UserId,
                        Message = $"A new rental request with the ID #{rentalRequest.RequestId} has been created by {rentalRequest.User.FullName}.",
                        Type = "New Request",
                        IsRead = false
                    };

                    _context.Notifications.Add(notification);
                }

                _context.SaveChanges();


            }


        }

    }
}
