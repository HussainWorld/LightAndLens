using LightAndLensCL.Models;

namespace LightAndLens.WebApp.Models
{
    public class CustomerViewModel
    {
        public IEnumerable<RentalRequest> PendingRequests { get; set; }
        public IEnumerable<Equipment> AvailableEquipment { get; set; }
        public string Search { get; set; }  // For search input
        public int? Status { get; set; }    // For status dropdown filter
    }
}
