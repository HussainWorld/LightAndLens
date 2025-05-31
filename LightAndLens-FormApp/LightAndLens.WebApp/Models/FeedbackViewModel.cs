using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace LightAndLens.WebApp.Models
{
    public class FeedbackViewModel
    {
        public int ReturnId { get; set; }

        public int RentalId { get; set; }

        public string EquipmentName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please provide a rating between 1 and 5.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5 stars.")]
        public int Rating { get; set; }

        [StringLength(1000, ErrorMessage = "Comments cannot exceed 1000 characters.")]
        public string? Comments { get; set; }

        [BindNever]
        public string CustomerName { get; set; } = string.Empty;  
    }
}
