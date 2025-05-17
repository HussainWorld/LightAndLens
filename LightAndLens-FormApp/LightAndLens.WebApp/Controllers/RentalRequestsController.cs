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
using Microsoft.AspNetCore.Authorization; // for AdminViewModel



namespace LightAndLens.WebApp.Controllers
{
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


    public IActionResult CustomerView()
    {
        string identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        var user = _context.Users.FirstOrDefault(u => u.IdentityUserId == identityUserId);

        if (user == null)
        {
            return Unauthorized(); // user not found in your DB
        }

        int userId = user.UserId;

        var pendingRequests = _context.RentalRequests
            .Where(r => r.UserId == userId && r.RequestStatusId == 2) // show only pending requests
            .Include(r => r.Equipment)
            .Include(r => r.RequestStatus)
            .ToList();

        return View(pendingRequests);
    }




}
}
