using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using LightAndLens.WebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [HttpPost]
        public async Task<IActionResult> UpdateMaintenanceAvailability(DashboardViewModel model)
        {
            if (model.MaintenanceItems != null)
            {
                foreach (var item in model.MaintenanceItems)
                {
                    var equipment = await _context.Equipment.FindAsync(item.EquipmentId);
                    if (equipment != null)
                    {
                        equipment.AvailabilityId = item.SelectedAvailabilityId;
                    }
                }

                await _context.SaveChangesAsync();
                TempData["Success"] = "Availability statuses updated successfully.";
            }

            return RedirectToAction("Index");
        }



        public async Task<IActionResult> Index()
        {
            // Get recent requests
            var recentRequests = await _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.User)
                .Include(r => r.RequestStatus)
                .OrderByDescending(r => r.RequestSetDate)
                .Take(5)
                .Select(r => new RecentRequestViewModel
                {
                    RequestId = r.RequestId,
                    EquipmentName = r.Equipment.EquipmentName,
                    RentedBy = r.User.FullName,
                    StartDate = r.RequestStartDate,
                    EndDate = r.RequestEndDate,
                    Status = r.RequestStatus.StatusName
                }).ToListAsync();

            // Get recent rentals
            var recentRentals = await _context.RentalTransactions
                .Include(t => t.Request)
                    .ThenInclude(r => r.User)
                .Include(t => t.Request)
                    .ThenInclude(r => r.Equipment)
                .OrderByDescending(t => t.StartDate)
                .Take(5)
                .Select(t => new RecentRentalViewModel
                {
                    RentalId = t.RentalId,
                    EquipmentName = t.Request.Equipment.EquipmentName,
                    RentedBy = t.Request.User.FullName,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    Status = t.Status
                }).ToListAsync();

            // Get recent returns
            var recentReturns = await _context.ReturnRecords
                .Include(ret => ret.Rental)
                    .ThenInclude(tr => tr.Request)
                        .ThenInclude(r => r.Equipment)
                .Include(ret => ret.Rental)
                    .ThenInclude(tr => tr.Request)
                        .ThenInclude(r => r.User)
                .OrderByDescending(r => r.ReturnDate)
                .Take(5)
                .Select(r => new RecentReturnViewModel
                {
                    ReturnId = r.ReturnId,
                    EquipmentName = r.Rental.Request.Equipment.EquipmentName,
                    RentedBy = r.Rental.Request.User.FullName,
                    ReturnDate = r.ReturnDate,
                    Condition = r.ConditionStatus,
                    Notes = r.Notes
                }).ToListAsync();

            
            // Get category availability stats
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


            // Get equipment under maintenance
             var maintenanceItems = await _context.Equipment
            .Where(e => e.AvailabilityId == 3) // under maintenance
            .Include(e => e.Category)
            .Include(e => e.Availability)
            .Select(e => new MaintenanceEquipmentViewModel
            {
                EquipmentId = e.EquipmentId,
                EquipmentName = e.EquipmentName,
                CategoryName = e.Category.CategoryName,
                AvailabilityStatus = e.Availability.AvailabilityStatusName,
                ConditionStatus = "Needs Maintenance", // Hardcoded for consistency
                SelectedAvailabilityId = (int)e.AvailabilityId,
                AvailabilityOptions = _context.AvailabilityStatuses

                .Where(a => a.AvailabilityId == 1 || a.AvailabilityId == 3)
                .Select(a => new SelectListItem
                {
                    Text = a.AvailabilityStatusName,
                    Value = a.AvailabilityId.ToString()
                }).ToList()
            })
            .ToListAsync();

            // Get counts of requests by status
            // Note: Assuming RequestStatusId 13 = Pending, 14 = Approved, 15 = Rejected
            //Status ID's Will be changed to the default 1,2,3 later
            var requestsPending = await _context.RentalRequests.CountAsync(r => r.RequestStatusId == 2);
            var requestsApproved = await _context.RentalRequests.CountAsync(r => r.RequestStatusId == 1);
            var requestsRejected = await _context.RentalRequests.CountAsync(r => r.RequestStatusId == 3);


            // Get category names and counts for JS chart
            var categoryData = await _context.Categories
            .Select(c => new
            {
                Name = c.CategoryName,
                Count = _context.Equipment.Count(e => e.CategoryId == c.CategoryId)
            })
            .ToListAsync();

                    var categoryNames = categoryData.Select(c => $"'{c.Name}'").ToList(); // for JS
                    var categoryCounts = categoryData.Select(c => c.Count).ToList();


            // Get rental trends for the last 30 days
            var rentalTrends = await _context.RentalTransactions
            .GroupBy(rt => rt.StartDate.Date)
            .OrderBy(g => g.Key)
            .Select(g => new
            {
                Date = g.Key.ToString("yyyy-MM-dd"),
                Count = g.Count()
            })
            .ToListAsync();

                    var rentalDates = rentalTrends.Select(d => $"'{d.Date}'").ToList();
                    var rentalCounts = rentalTrends.Select(d => d.Count).ToList();


            // Get top 5 rented equipment
            var topRented = await _context.RentalTransactions
            .Include(rt => rt.Request)
                .ThenInclude(r => r.Equipment)
            .GroupBy(rt => rt.Request.Equipment.EquipmentName)
            .Select(g => new
            {
                Name = g.Key,
                Count = g.Count()
            })
            .OrderByDescending(x => x.Count)
            .Take(5) // Top 5
            .ToListAsync();

                    var topNames = topRented.Select(t => $"'{t.Name}'").ToList();
                    var topCounts = topRented.Select(t => t.Count).ToList();



            // Get total equipment, active rentals, pending requests, overdue returns, and under maintenance counts
            var vm = new DashboardViewModel
            {
                TotalEquipment = await _context.Equipment.SumAsync(e => e.Quantity),
                ActiveRentals = await _context.RentalTransactions.CountAsync(r => r.Status == "Ongoing"),
                PendingRequests = await _context.RentalRequests.CountAsync(r => r.RequestStatusId == 2),
                OverdueReturns = await _context.RentalTransactions.CountAsync(r => r.Status == "Ongoing" && r.EndDate < DateTime.Now),
                UnderMaintenance = await _context.Equipment.CountAsync(e => e.AvailabilityId == 3),
                
                
                RecentRequests = recentRequests,
                RecentRentals = recentRentals,
                RecentReturns = recentReturns,
                CategoryStatuses = categoryStats,
                MaintenanceItems = maintenanceItems,
                RequestsPending = requestsPending,
                RequestsApproved = requestsApproved,
                RequestsRejected = requestsRejected,
                CategoryNames = categoryNames,
                CategoryCounts = categoryCounts,
                RentalDates = rentalDates,
                RentalCounts = rentalCounts,
                TopRentedEquipmentNames = topNames,
                TopRentedCounts = topCounts,



            };

             



            return View(vm);
        }
    }
}
