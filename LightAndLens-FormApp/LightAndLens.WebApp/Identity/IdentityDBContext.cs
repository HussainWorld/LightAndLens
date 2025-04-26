using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LightAndLens.WebApp.Identity;

namespace LightAndLens.WebApp.Identity
{
    public class IdentityDBContext : IdentityDbContext<ApplicationUser>
    {
        public IdentityDBContext(DbContextOptions<IdentityDBContext> options)
            : base(options)
        {
        }
    }
}
