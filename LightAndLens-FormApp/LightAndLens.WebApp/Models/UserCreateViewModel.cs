using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LightAndLens.WebApp.Models
{
    public class UserCreateViewModel
    {
        [Required(ErrorMessage = "Full name is required.")]
        [RegularExpression(@"^(\w+\s+\w+.*)$", ErrorMessage = "Please enter first and last name.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{8,15}$", ErrorMessage = "Phone must be numbers only.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select a role.")]
        public string RoleId { get; set; }

        public List<SelectListItem>? Roles { get; set; } 

    }
}
