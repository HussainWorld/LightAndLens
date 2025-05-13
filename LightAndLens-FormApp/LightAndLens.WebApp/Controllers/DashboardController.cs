using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using LightAndLens.WebApp.Models;

namespace LightAndLens.WebApp.Controllers
{
    //[Authorize(Roles = "Admin,Manager")]
    public class DashboardController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public DashboardController(LightAndLensDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Get recent requests, rentals, and returns Tables
            var recentRequests = await _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.User)
                .Include(r => r.RequestStatus)
                .OrderByDescending(r => r.RequestSetDate)
                .Take(10)
                .Select(r => new RecentRequestViewModel
                {
                    RequestId = r.RequestId,
                    EquipmentName = r.Equipment.EquipmentName,
                    RentedBy = r.User.FullName,
                    StartDate = r.RequestStartDate,
                    EndDate = r.RequestEndDate,
                    Status = r.RequestStatus.StatusName
                }).ToListAsync();

            var recentRentals = await _context.RentalTransactions
                .Include(t => t.Request)
                    .ThenInclude(r => r.User)
                .Include(t => t.Request)
                    .ThenInclude(r => r.Equipment)
                .OrderByDescending(t => t.StartDate)
                .Take(10)
                .Select(t => new RecentRentalViewModel
                {
                    RentalId = t.RentalId,
                    EquipmentName = t.Request.Equipment.EquipmentName,
                    RentedBy = t.Request.User.FullName,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    Status = t.Status
                }).ToListAsync();

            var recentReturns = await _context.ReturnRecords
                .Include(ret => ret.Rental)
                    .ThenInclude(tr => tr.Request)
                        .ThenInclude(r => r.Equipment)
                .Include(ret => ret.Rental)
                    .ThenInclude(tr => tr.Request)
                        .ThenInclude(r => r.User)
                .OrderByDescending(r => r.ReturnDate)
                .Take(10)
                .Select(r => new RecentReturnViewModel
                {
                    ReturnId = r.ReturnId,
                    EquipmentName = r.Rental.Request.Equipment.EquipmentName,
                    RentedBy = r.Rental.Request.User.FullName,
                    ReturnDate = r.ReturnDate,
                    Condition = r.ConditionStatus,
                    Notes = r.Notes
                }).ToListAsync();

            //Progress bars for Equipment category availability
            //var categoryStats = await _context.Categories
            //    .Select(cat => new CategoryAvailabilityViewModel
            //    {
            //    CategoryName = cat.CategoryName,
            //    Total = _context.Equipment.Count(e => e.CategoryId == cat.CategoryId),
            //    Available = _context.Equipment.Count(e => e.CategoryId == cat.CategoryId && e.AvailabilityId == 1)
            //    })
            //    .ToListAsync();
                 var categoryStats = await _context.Categories
                .Select(category => new CategoryAvailabilityViewModel
                {
                    CategoryName = category.CategoryName,
                    Total = _context.Equipment
                                .Where(e => e.CategoryId == category.CategoryId)
                                .Count(),

                    Available = _context.Equipment
                                .Where(e => e.CategoryId == category.CategoryId && e.AvailabilityId == 1)
                                .Count()
                })
                .ToListAsync();



            var vm = new DashboardViewModel
            {
                TotalEquipment = await _context.Equipment.SumAsync(e => e.Quantity),
                ActiveRentals = await _context.RentalTransactions.CountAsync(r => r.Status == "Ongoing"),
                PendingRequests = await _context.RentalRequests.CountAsync(r => r.RequestStatusId == 1),
                OverdueReturns = await _context.RentalTransactions.CountAsync(r => r.Status == "Ongoing" && r.EndDate < DateTime.Now),
                UnderMaintenance = await _context.Equipment.CountAsync(e => e.ConditionId == 3),

                RecentRequests = recentRequests,
                RecentRentals = recentRentals,
                RecentReturns = recentReturns,
                CategoryStatuses = categoryStats
            };

            return View(vm);
        }
    }
}
