using Microsoft.AspNetCore.Mvc.Rendering;

namespace LightAndLens.WebApp.Models
{
    public class MaintenanceEquipmentViewModel
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string CategoryName { get; set; }
        public string AvailabilityStatus { get; set; }
        public string ConditionStatus { get; set; }
        public int SelectedAvailabilityId { get; set; }
        public List<SelectListItem>? AvailabilityOptions { get; set; }
    }
}
