using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using LightAndLens.WebApp.Models;

namespace LightAndLens.WebApp.Controllers
{
    public class RentalTransactionsController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public RentalTransactionsController(LightAndLensDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string status, DateTime? startDate, DateTime? endDate, string search)
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

            var result = await query.Select(rt => new RentalTransactionViewModel
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













    }

}
