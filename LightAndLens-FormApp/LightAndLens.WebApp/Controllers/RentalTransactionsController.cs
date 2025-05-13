using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;

namespace LightAndLens.WebApp.Controllers
{
    public class RentalTransactionsController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public RentalTransactionsController(LightAndLensDBContext context)
        {
            _context = context;
        }

        // GET: RentalTransactions
        public async Task<IActionResult> Index()
        {
            var lightAndLensDBContext = _context.RentalTransactions.Include(r => r.Request).Include(r => r.User);
            return View(await lightAndLensDBContext.ToListAsync());
        }

        // GET: RentalTransactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RentalTransactions == null)
            {
                return NotFound();
            }

            var rentalTransaction = await _context.RentalTransactions
                .Include(r => r.Request)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RentalId == id);
            if (rentalTransaction == null)
            {
                return NotFound();
            }

            return View(rentalTransaction);
        }

        // GET: RentalTransactions/Create
        public IActionResult Create()
        {
            ViewData["RequestId"] = new SelectList(_context.RentalRequests, "RequestId", "RequestId");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email");
            return View();
        }

        
        


        // POST: RentalTransactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RentalId,UserId,StartDate,EndDate,RentalFee,DepositPaid,Status,RequestId")] RentalTransaction rentalTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalTransaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RequestId"] = new SelectList(_context.RentalRequests, "RequestId", "RequestId", rentalTransaction.RequestId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", rentalTransaction.UserId);
            return View(rentalTransaction);
        }

        // GET: RentalTransactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RentalTransactions == null)
            {
                return NotFound();
            }

            var rentalTransaction = await _context.RentalTransactions.FindAsync(id);
            if (rentalTransaction == null)
            {
                return NotFound();
            }
            ViewData["RequestId"] = new SelectList(_context.RentalRequests, "RequestId", "RequestId", rentalTransaction.RequestId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", rentalTransaction.UserId);
            return View(rentalTransaction);
        }

        // POST: RentalTransactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RentalId,UserId,StartDate,EndDate,RentalFee,DepositPaid,Status,RequestId")] RentalTransaction rentalTransaction)
        {
            if (id != rentalTransaction.RentalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalTransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalTransactionExists(rentalTransaction.RentalId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RequestId"] = new SelectList(_context.RentalRequests, "RequestId", "RequestId", rentalTransaction.RequestId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", rentalTransaction.UserId);
            return View(rentalTransaction);
        }

        // GET: RentalTransactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RentalTransactions == null)
            {
                return NotFound();
            }

            var rentalTransaction = await _context.RentalTransactions
                .Include(r => r.Request)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RentalId == id);
            if (rentalTransaction == null)
            {
                return NotFound();
            }

            return View(rentalTransaction);
        }

        // POST: RentalTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RentalTransactions == null)
            {
                return Problem("Entity set 'LightAndLensDBContext.RentalTransactions'  is null.");
            }
            var rentalTransaction = await _context.RentalTransactions.FindAsync(id);
            if (rentalTransaction != null)
            {
                _context.RentalTransactions.Remove(rentalTransaction);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalTransactionExists(int id)
        {
          return (_context.RentalTransactions?.Any(e => e.RentalId == id)).GetValueOrDefault();
        }
    }
}
