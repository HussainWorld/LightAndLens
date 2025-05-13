namespace LightAndLens.WebApp.Models
{
    public class RecentReturnViewModel
    {
        public int ReturnId { get; set; }
        public string EquipmentName { get; set; }
        public string RentedBy { get; set; }
        public DateTime ReturnDate { get; set; }
        public string Condition { get; set; }
        public string Notes { get; set; }
    }
}
