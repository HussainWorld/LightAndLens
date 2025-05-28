using LightAndLensCL.Models;
using System.Collections.Generic;

namespace LightAndLens.WebApp.Models
{
    public class AdminViewModel
    {
        public List<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();
        public string Search { get; set; }
        public int? Status { get; set; }
    }
}
