using Microsoft.AspNetCore.Identity;

namespace LightAndLens.WebApp.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;

    }
}
