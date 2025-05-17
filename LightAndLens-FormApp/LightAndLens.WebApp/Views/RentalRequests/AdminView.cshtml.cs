using LightAndLensCL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LightAndLens.WebApp.Views.RentalRequests
{
    public class AdminViewModel : PageModel
    {
        public List<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();
        public string Search { get; set; }
        public int? Status { get; set; }

        public void OnGet()
        {
        }
    }
}
