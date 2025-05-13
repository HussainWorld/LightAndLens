namespace LightAndLens.WebApp.Models
{
    public class RecentRequestViewModel
    {
        public int RequestId { get; set; }
        public string EquipmentName { get; set; }
        public string RentedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
