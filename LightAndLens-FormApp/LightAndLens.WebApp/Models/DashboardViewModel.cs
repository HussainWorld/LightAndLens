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
        public int RequestsPending { get; set; }
        public int RequestsApproved { get; set; }
        public int RequestsRejected { get; set; }
        public List<string> CategoryNames { get; set; }
        public List<int> CategoryCounts { get; set; }
        public List<string> RentalDates { get; set; }
        public List<int> RentalCounts { get; set; }
        public List<string> TopRentedEquipmentNames { get; set; }
        public List<int> TopRentedCounts { get; set; }




    }
}
