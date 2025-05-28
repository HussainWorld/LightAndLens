using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LightAndLens.WebApp.Models
{
    public class ReturnRecordViewModel
    {
        public int ReturnId { get; set; }
        public int RentalId { get; set; }

        public string EquipmentName { get; set; }
        public string RentedBy { get; set; }

        public DateTime ReturnDate { get; set; }
        public string ConditionStatus { get; set; }
        public string Notes { get; set; }

        // For pending form
        public int? SelectedConditionId { get; set; }
        public int? SelectedAvailabilityId { get; set; }

        public List<SelectListItem> ConditionOptions { get; set; }
        public List<SelectListItem> AvailabilityOptions { get; set; }
        public List<ReturnRecordViewModel> PendingReturns { get; set; }
        public List<ReturnRecordViewModel> HistoryReturns { get; set; }
    }
}
