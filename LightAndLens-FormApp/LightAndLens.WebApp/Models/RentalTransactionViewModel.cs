namespace LightAndLens.WebApp.Models
{
    public class RentalTransactionViewModel
    {
        public int RentalId { get; set; }
        public string EquipmentName { get; set; }
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal RentalFee { get; set; }
        public decimal DepositPaid { get; set; }
        public string Status { get; set; } // "Ongoing" or "Overdue"
    }
}
