using LightAndLensCL.Models;
using Microsoft.EntityFrameworkCore;
using LightAndLens.WebApp.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.DependencyInjection;
using LightAndLens.WebApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<LogHelper>();

builder.Services.AddDbContext<LightAndLensDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
    sql => sql.EnableRetryOnFailure()
    ));

builder.Services.AddDbContext<IdentityDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AuthConnection"),
    sql => sql.EnableRetryOnFailure()
    ));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.SignIn.RequireConfirmedAccount = false; // No email confirmation required
    options.Lockout.AllowedForNewUsers = false;
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(0);
    options.Lockout.MaxFailedAccessAttempts = 10;
})
.AddEntityFrameworkStores<IdentityDBContext>()
.AddDefaultTokenProviders();

builder.Services.AddTransient<IEmailSender, LightAndLens.WebApp.Services.DummyEmailSender>();


var app = builder.Build();
await SeedRolesAsync(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "..", "SharedImages")),
    RequestPath = "/SharedImages"
});

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();



static async Task SeedRolesAsync(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    string[] roles = { "Admin", "Staff", "Customer" };

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}


app.Run();
