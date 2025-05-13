namespace LightAndLens.WebApp.Models
{
    public class DashboardViewModel
    {
        public int TotalEquipment { get; set; }
        public int ActiveRentals { get; set; }
        public int PendingRequests { get; set; }
        public int OverdueReturns { get; set; }
        public int UnderMaintenance { get; set; }
    }
}
