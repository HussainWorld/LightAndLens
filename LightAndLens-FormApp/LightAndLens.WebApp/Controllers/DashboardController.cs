using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models; 
using LightAndLens.WebApp.Models;



namespace LightAndLens.WebApp.Controllers
{
   // [Authorize(Roles = "Admin,Manager")] //Restricts access to Admins and Managers
    public class DashboardController : Controller
{
    private readonly LightAndLensDBContext _context;

    public DashboardController(LightAndLensDBContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var vm = new DashboardViewModel
        {
            TotalEquipment = await _context.Equipment.SumAsync(e => e.Quantity),
            ActiveRentals = await _context.RentalTransactions.CountAsync(r => r.Status == "Ongoing"),
            PendingRequests = await _context.RentalRequests.CountAsync(r => r.RequestStatusId == 1), // 1 = Pending
            OverdueReturns = await _context.RentalTransactions.CountAsync(r =>
                r.Status == "Ongoing" && r.EndDate < DateTime.Now),
            UnderMaintenance = await _context.Equipment.CountAsync(e => e.ConditionId == 3) // 3 = Maintenance
        };

        return View(vm); //This sends the ViewModel to the Razor view
    }
}
}


