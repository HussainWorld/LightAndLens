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
    public class ReturnRecordsController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public ReturnRecordsController(LightAndLensDBContext context)
        {
            _context = context;
        }

        // GET: ReturnRecords
        public async Task<IActionResult> Index()
        {
            var lightAndLensDBContext = _context.ReturnRecords.Include(r => r.Rental);
            return View(await lightAndLensDBContext.ToListAsync());
        }

        // GET: ReturnRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ReturnRecords == null)
            {
                return NotFound();
            }

            var returnRecord = await _context.ReturnRecords
                .Include(r => r.Rental)
                .FirstOrDefaultAsync(m => m.ReturnId == id);
            if (returnRecord == null)
            {
                return NotFound();
            }

            return View(returnRecord);
        }

        // GET: ReturnRecords/Create
        public IActionResult Create()
        {
            ViewData["RentalId"] = new SelectList(_context.RentalTransactions, "RentalId", "Status");
            return View();
        }

        // POST: ReturnRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReturnId,RentalId,ReturnDate,ConditionStatus,Notes")] ReturnRecord returnRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(returnRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RentalId"] = new SelectList(_context.RentalTransactions, "RentalId", "Status", returnRecord.RentalId);
            return View(returnRecord);
        }

        // GET: ReturnRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ReturnRecords == null)
            {
                return NotFound();
            }

            var returnRecord = await _context.ReturnRecords.FindAsync(id);
            if (returnRecord == null)
            {
                return NotFound();
            }
            ViewData["RentalId"] = new SelectList(_context.RentalTransactions, "RentalId", "Status", returnRecord.RentalId);
            return View(returnRecord);
        }

        // POST: ReturnRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReturnId,RentalId,ReturnDate,ConditionStatus,Notes")] ReturnRecord returnRecord)
        {
            if (id != returnRecord.ReturnId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(returnRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReturnRecordExists(returnRecord.ReturnId))
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
            ViewData["RentalId"] = new SelectList(_context.RentalTransactions, "RentalId", "Status", returnRecord.RentalId);
            return View(returnRecord);
        }

        // GET: ReturnRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ReturnRecords == null)
            {
                return NotFound();
            }

            var returnRecord = await _context.ReturnRecords
                .Include(r => r.Rental)
                .FirstOrDefaultAsync(m => m.ReturnId == id);
            if (returnRecord == null)
            {
                return NotFound();
            }

            return View(returnRecord);
        }

        // POST: ReturnRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ReturnRecords == null)
            {
                return Problem("Entity set 'LightAndLensDBContext.ReturnRecords'  is null.");
            }
            var returnRecord = await _context.ReturnRecords.FindAsync(id);
            if (returnRecord != null)
            {
                _context.ReturnRecords.Remove(returnRecord);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReturnRecordExists(int id)
        {
          return (_context.ReturnRecords?.Any(e => e.ReturnId == id)).GetValueOrDefault();
        }
    }
}
