using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using LightAndLens.WebApp.Models;
using System.Security.Claims;
using LightAndLens.WebApp.Services;
using Microsoft.AspNetCore.Authorization;

namespace LightAndLens.WebApp.Controllers
{
    [Authorize]
    public class RentalTransactionsController : Controller
    {
        private readonly LightAndLensDBContext _context;
        private readonly LogHelper _logHelper;
        public RentalTransactionsController(LightAndLensDBContext context, LogHelper logHelper)
        {
            _context = context;
            _logHelper = logHelper;
        }

        
        public async Task<IActionResult> Index(string status, DateTime? startDate, DateTime? endDate, string search)
        {
            // Get logged-in user from Identity
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            // Base query with includes
            var query = _context.RentalTransactions
                .Include(rt => rt.Request).ThenInclude(r => r.Equipment)
                .Include(rt => rt.User)
                .AsQueryable();

            // Role-based filtering
            if (User.IsInRole("Customer") && currentUser != null)
            {
                query = query.Where(rt => rt.UserId == currentUser.UserId);
            }

            // Status filter
            if (!string.IsNullOrEmpty(status))
            {
                if (status == "Ongoing")
                    query = query.Where(rt => rt.EndDate >= DateTime.Now);
                else if (status == "Overdue")
                    query = query.Where(rt => rt.EndDate < DateTime.Now);
            }

            // Date range filters
            if (startDate.HasValue)
                query = query.Where(rt => rt.StartDate >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(rt => rt.EndDate <= endDate.Value);

            // Search filter
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(rt =>
                    rt.User.FullName.Contains(search) ||
                    rt.Request.Equipment.EquipmentName.Contains(search));
            }


            // Preload all RentalIDs from the current query
            var rentalIds = await query.Select(rt => rt.RentalId).ToListAsync();

            // Get RentalIDs that already have a return record
            var returnIds = await _context.ReturnRecords
                .Where(r => rentalIds.Contains(r.RentalId))
                .Select(r => r.RentalId)
                .ToListAsync();

            // Projection to ViewModel
            var result = await query.Select(rt => new RentalTransactionViewModel
            {
                RentalId = rt.RentalId,
                EquipmentName = rt.Request.Equipment.EquipmentName,
                CustomerName = rt.User.FullName,
                StartDate = rt.StartDate,
                EndDate = rt.EndDate,
                RentalFee = rt.RentalFee,
                DepositPaid = (decimal)rt.DepositPaid,
                Status = rt.EndDate < DateTime.Now ? "Overdue" : "Ongoing",
                ReturnExists = returnIds.Contains(rt.RentalId)
            }).ToListAsync();

            // Logging access
            if (currentUser != null)
            {
                string actionLabel = User.IsInRole("Customer") ? "Viewed My Rental Orders" : "Viewed All Rental Transactions";
                await _logHelper.LogActionAsync(currentUser.UserId, actionLabel);
            }

            return View(result);
        }


        public async Task<IActionResult> Search(string status, DateTime? startDate, DateTime? endDate, string search)
        {
            var query = _context.RentalTransactions
                .Include(rt => rt.Request).ThenInclude(r => r.Equipment)
                .Include(rt => rt.User)
                .AsQueryable();

            if (!string.IsNullOrEmpty(status))
            {
                if (status == "Ongoing")
                    query = query.Where(rt => rt.EndDate >= DateTime.Now);
                else if (status == "Overdue")
                    query = query.Where(rt => rt.EndDate < DateTime.Now);
            }

            if (startDate.HasValue)
                query = query.Where(rt => rt.StartDate >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(rt => rt.EndDate <= endDate.Value);

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(rt =>
                    rt.User.FullName.Contains(search) ||
                    rt.Request.Equipment.EquipmentName.Contains(search));
            }

            var filtered = await query.Select(rt => new RentalTransactionViewModel
            {
                RentalId = rt.RentalId,
                EquipmentName = rt.Request.Equipment.EquipmentName,
                CustomerName = rt.User.FullName,
                StartDate = rt.StartDate,
                EndDate = rt.EndDate,
                RentalFee = rt.RentalFee,
                DepositPaid = (decimal)rt.DepositPaid,
                Status = rt.EndDate < DateTime.Now ? "Overdue" : "Ongoing"
            }).ToListAsync();

            return PartialView("_RentalTransactionPartial", filtered);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var rental = await _context.RentalTransactions
                .Include(r => r.Request)
                    .ThenInclude(r => r.Equipment)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RentalId == id);

            if (rental == null)
                return NotFound();
            // Log the action
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            if (user != null)
            {
                await _logHelper.LogActionAsync(user.UserId, $"Viewed Rental Details: Rental #{rental.RentalId}");
            }

            return View(rental); // View expects RentalTransaction model
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var rentalTransaction = await _context.RentalTransactions.FindAsync(id);
            if (rentalTransaction == null)
                return NotFound();

            ViewData["RequestId"] = new SelectList(_context.RentalRequests, "RequestId", "RequestId", rentalTransaction.RequestId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FullName", rentalTransaction.UserId);
            return View(rentalTransaction);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalId,UserId,StartDate,EndDate,RentalFee,DepositPaid,Status,RequestId")] RentalTransaction rentalTransaction)
        {
            if (id != rentalTransaction.RentalId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalTransaction);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.RentalTransactions.Any(e => e.RentalId == rentalTransaction.RentalId))
                        return NotFound();
                    else
                        throw;
                }
            }

            ViewData["RequestId"] = new SelectList(_context.RentalRequests, "RequestId", "RequestId", rentalTransaction.RequestId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "FullName", rentalTransaction.UserId);
            return View(rentalTransaction);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var rental = await _context.RentalTransactions
                .Include(r => r.Request)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RentalId == id);

            if (rental == null)
                return NotFound();

            return View(rental);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rentalTransaction = await _context.RentalTransactions.FindAsync(id);
            if (rentalTransaction != null)
            {
                _context.RentalTransactions.Remove(rentalTransaction);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> SubmitForReturn(int id)
        {
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            var transaction = await _context.RentalTransactions.FindAsync(id);
            if (transaction == null || transaction.UserId != user?.UserId)
                return NotFound();

            // Add a return record with minimal data for now (to be completed by staff later)
            var returnRecord = new ReturnRecord
            {
                RentalId = transaction.RentalId,
                ReturnDate = DateTime.Now,
                ConditionStatus = "Pending",
                Notes = "Submitted by user"
            };

            _context.ReturnRecords.Add(returnRecord);
            await _context.SaveChangesAsync();

            await _logHelper.LogActionAsync(user.UserId, $"Submitted return for Rental #{transaction.RentalId}");
            TempData["Success"] = "Return submitted successfully.";
            return RedirectToAction("Create", "Feedback", new { returnId = returnRecord.ReturnId });
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Staff")]
        public async Task<IActionResult> MarkForReturn(int id)
        {
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            var transaction = await _context.RentalTransactions.FindAsync(id);
            if (transaction == null)
                return NotFound();

            var returnRecord = new ReturnRecord
            {
                RentalId = transaction.RentalId,
                ReturnDate = DateTime.Now,
                ConditionStatus = "Pending",
                Notes = "Marked for return by staff"
            };

            _context.ReturnRecords.Add(returnRecord);
            await _context.SaveChangesAsync();

            // Safe logging with null check
            if (user != null)
            {
                await _logHelper.LogActionAsync(user.UserId, $"Marked return for Rental #{transaction.RentalId}");
            }
            else
            {
                // Optional: Log warning or handle gracefully if user is null
                Console.WriteLine($"Warning: Could not log action - user not found for identityId {identityId}");
            }
            TempData["Success"] = "Return submitted successfully.";
            return RedirectToAction("Index");
        }















    }

}
