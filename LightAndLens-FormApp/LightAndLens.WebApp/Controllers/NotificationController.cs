using LightAndLensCL.Models;
using Microsoft.AspNetCore.Mvc;

namespace LightAndLens.WebApp.Controllers
{
    public class NotificationController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public NotificationController(LightAndLensDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var notificationList = _context.Notifications;

            ViewBag.NotificationList = notificationList;

            return View(ViewBag);
        }
    }
}
