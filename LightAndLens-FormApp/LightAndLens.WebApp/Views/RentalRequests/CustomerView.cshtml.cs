using LightAndLensCL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LightAndLens.WebApp.Views.RentalRequests
{
    public class CustomerViewModel : PageModel
    {

        public IEnumerable<RentalRequest> PendingRequests { get; set; }
        public IEnumerable<Equipment> AvailableEquipment { get; set; }
        public string Search { get; set; }  // For search input
        public int? Status { get; set; }    // For status dropdown filter

        public void OnGet()
        {
        }
    }
}
