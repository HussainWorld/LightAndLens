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
    public class RentalRequestsController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public RentalRequestsController(LightAndLensDBContext context)
        {
            _context = context;
        }

        // GET: RentalRequests
        public async Task<IActionResult> Index()
        {
            var lightAndLensDBContext = _context.RentalRequests.Include(r => r.Equipment).Include(r => r.RequestStatus).Include(r => r.User);
            return View(await lightAndLensDBContext.ToListAsync());
        }

        // GET: RentalRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RentalRequests == null)
            {
                return NotFound();
            }

            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.RequestStatus)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (rentalRequest == null)
            {
                return NotFound();
            }

            return View(rentalRequest);
        }

        // GET: RentalRequests/Create
        public IActionResult Create()
        {
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "EquipmentId", "Description");
            ViewData["RequestStatusId"] = new SelectList(_context.RequestStatuses, "RequestStatusId", "StatusName");
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email");
            return View();
        }

        // POST: RentalRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RequestId,UserId,EquipmentId,RequestStartDate,RequestEndDate,RequestStatusId,RequestSetDate")] RentalRequest rentalRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rentalRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "EquipmentId", "Description", rentalRequest.EquipmentId);
            ViewData["RequestStatusId"] = new SelectList(_context.RequestStatuses, "RequestStatusId", "StatusName", rentalRequest.RequestStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", rentalRequest.UserId);
            return View(rentalRequest);
        }

        // GET: RentalRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RentalRequests == null)
            {
                return NotFound();
            }

            var rentalRequest = await _context.RentalRequests.FindAsync(id);
            if (rentalRequest == null)
            {
                return NotFound();
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "EquipmentId", "Description", rentalRequest.EquipmentId);
            ViewData["RequestStatusId"] = new SelectList(_context.RequestStatuses, "RequestStatusId", "StatusName", rentalRequest.RequestStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", rentalRequest.UserId);
            return View(rentalRequest);
        }

        // POST: RentalRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RequestId,UserId,EquipmentId,RequestStartDate,RequestEndDate,RequestStatusId,RequestSetDate")] RentalRequest rentalRequest)
        {
            if (id != rentalRequest.RequestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rentalRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentalRequestExists(rentalRequest.RequestId))
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
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "EquipmentId", "Description", rentalRequest.EquipmentId);
            ViewData["RequestStatusId"] = new SelectList(_context.RequestStatuses, "RequestStatusId", "StatusName", rentalRequest.RequestStatusId);
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "Email", rentalRequest.UserId);
            return View(rentalRequest);
        }

        // GET: RentalRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RentalRequests == null)
            {
                return NotFound();
            }

            var rentalRequest = await _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.RequestStatus)
                .Include(r => r.User)
                .FirstOrDefaultAsync(m => m.RequestId == id);
            if (rentalRequest == null)
            {
                return NotFound();
            }

            return View(rentalRequest);
        }

        // POST: RentalRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RentalRequests == null)
            {
                return Problem("Entity set 'LightAndLensDBContext.RentalRequests'  is null.");
            }
            var rentalRequest = await _context.RentalRequests.FindAsync(id);
            if (rentalRequest != null)
            {
                _context.RentalRequests.Remove(rentalRequest);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentalRequestExists(int id)
        {
          return (_context.RentalRequests?.Any(e => e.RequestId == id)).GetValueOrDefault();
        }
    }
}
