using LightAndLens.WebApp.Models; // for ViewModel
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using LightAndLensCL.Models;
using System.Security.Claims; // in case you want to secure it

namespace LightAndLens.WebApp.Controllers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public NotificationController(LightAndLensDBContext context)
        {
            _context = context;
        }

        //public void NotificationsLogic()
        //{
        //    var rentalRequests = _context.RentalRequests
        //        .Where(r => r.RequestStatusId == 1) // Assuming 1 is the status for pending requests
        //        .ToList();
        //}

        public IActionResult Index(string IsReadFilter)
        {
                // Get the current user's ID from claims
                string identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = _context.Users.FirstOrDefault(u => u.IdentityUserId == identityUserId);
                var userId = user.UserId;

                //NotificationsLogic();


                // Filter notifications for that user
                var notifications = _context.Notifications
                .Where(n => n.UserId == userId) //filter by current user
                .OrderByDescending(n => n.NotificationId)
                .Select(n => new NotificationViewModel
                {
                    NotificationID = n.NotificationId,
                    UserID = n.UserId,
                    Message = n.Message,
                    Type = n.Type,
                    IsRead = n.IsRead
                })
                .ToList();

            //if (!string.IsNullOrEmpty(IsReadFilter))
            //{
            //    if (IsReadFilter == "1" || IsReadFilter == "0")
            //    {
            //        bool isReadValue = IsReadFilter == "1";
            //        notifications = notifications.Where(n => n.IsRead == isReadValue);
            //    }
            //}

            var viewModel = new NotificationListViewModel
                {
                    Notifications = notifications
                };

                return View(viewModel);
        }

        //public IActionResult CreateNotification(string message, string type)
        //{
        //    // Get the current user's ID from claims
        //    string identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var user = _context.Users.FirstOrDefault(u => u.IdentityUserId == identityUserId);
        //    var userId = user.UserId;
        //    // Create a new notification
        //    var notification = new Notification
        //    {
        //        UserId = userId,
        //        Message = message,
        //        Type = type,
        //        IsRead = false // New notifications are unread by default
        //    };
        //    _context.Notifications.Add(notification);
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}


        public IActionResult Details(int id)
        {
            var notification = _context.Notifications
                .FirstOrDefault(n => n.NotificationId == id);

            if (notification == null)
            {
                return NotFound();
            }

            //mark notidication as read when opening notification details page
            if (!notification.IsRead)
            {
                notification.IsRead = true;
                _context.SaveChanges();
            }

            var viewModel = new NotificationViewModel
            {
                NotificationID = notification.NotificationId,
                UserID = notification.UserId,
                Message = notification.Message,
                Type = notification.Type,
                IsRead = notification.IsRead
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var notification = _context.Notifications
                .FirstOrDefault(n => n.NotificationId == id);
            if (notification == null)
            {
                return NotFound();
            }
            _context.Notifications.Remove(notification);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}
