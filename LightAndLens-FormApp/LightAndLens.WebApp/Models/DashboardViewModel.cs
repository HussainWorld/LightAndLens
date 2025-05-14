namespace LightAndLens.WebApp.Models
{
    public class DashboardViewModel
    {
        public int TotalEquipment { get; set; }
        public int ActiveRentals { get; set; }
        public int PendingRequests { get; set; }
        public int OverdueReturns { get; set; }
        public int UnderMaintenance { get; set; }
        public List<RecentRequestViewModel> RecentRequests { get; set; }
        public List<RecentRentalViewModel> RecentRentals { get; set; }
        public List<RecentReturnViewModel> RecentReturns { get; set; }
        public List<CategoryAvailabilityViewModel> CategoryStatuses { get; set; }
        public List<MaintenanceEquipmentViewModel> MaintenanceItems { get; set; }



    }
}
