namespace LightAndLens.WebApp.Models
{
    public class RecentRentalViewModel
    {
        public int RentalId { get; set; }
        public string EquipmentName { get; set; }
        public string RentedBy { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
    }
}
