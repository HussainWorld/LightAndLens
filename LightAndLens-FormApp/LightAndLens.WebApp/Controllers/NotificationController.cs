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

        public IActionResult Index(string? IsReadFilter)
        {
                // Get the current user's ID from claims
                string identityUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = _context.Users.FirstOrDefault(u => u.IdentityUserId == identityUserId);
                var userId = user.UserId;

                // Start with base query
                var notificationsQuery = _context.Notifications
                    .Where(n => n.UserId == userId);

            //// Apply filter if needed
            if (!string.IsNullOrEmpty(IsReadFilter) && (IsReadFilter == "0" || IsReadFilter == "1"))
            {
                bool isReadValue = IsReadFilter == "1";
                notificationsQuery = notificationsQuery.Where(n => n.IsRead == isReadValue);
            }

            // Execute the query and project to view model
            var notifications = notificationsQuery
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
