namespace LightAndLens.WebApp.Models
{
    public class NotificationViewModel
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public bool IsRead { get; set; }
    }
}
