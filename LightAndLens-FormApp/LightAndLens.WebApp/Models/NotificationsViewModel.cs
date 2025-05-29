using LightAndLensCL.Models;
using Microsoft.AspNetCore.Mvc;

namespace LightAndLens.WebApp.Models
{
    public class NotificationsViewModel : Controller
    {
        public IEnumerable<Notification> NotificationList { get; set; }
        public int NotificatoinId { get; set; }
        public int UserId { get; set; }
        public string? Message { get; set; }
        public string Type { get; set; }
        public bool IsRead { get; set; }

    }
}
