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
    public class EquipmentController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public EquipmentController(LightAndLensDBContext context)
        {
            _context = context;
        }

        // GET: Equipments
        public async Task<IActionResult> Index()
        {
            var lightAndLensDBContext = _context.Equipment.Include(e => e.Availability).Include(e => e.Category).Include(e => e.Condition);
            return View(await lightAndLensDBContext.ToListAsync());
        }

        // GET: Equipments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Equipment == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipment
                .Include(e => e.Availability)
                .Include(e => e.Category)
                .Include(e => e.Condition)
                .FirstOrDefaultAsync(m => m.EquipmentId == id);
            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
        }

        // GET: Equipments/Create
        public IActionResult Create()
        {
            ViewData["AvailabilityId"] = new SelectList(_context.AvailabilityStatuses, "AvailabilityId", "AvailabilityStatusName");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            ViewData["ConditionId"] = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName");
            return View();
        }

        // POST: Equipments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EquipmentId,EquipmentName,Description,CategoryId,RentalPricePerDay,Quantity,ConditionId,AvailabilityId")] Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AvailabilityId"] = new SelectList(_context.AvailabilityStatuses, "AvailabilityId", "AvailabilityStatusName", equipment.AvailabilityId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", equipment.CategoryId);
            ViewData["ConditionId"] = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName", equipment.ConditionId);
            return View(equipment);
        }

        // GET: Equipments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Equipment == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipment.FindAsync(id);
            if (equipment == null)
            {
                return NotFound();
            }
            ViewData["AvailabilityId"] = new SelectList(_context.AvailabilityStatuses, "AvailabilityId", "AvailabilityStatusName", equipment.AvailabilityId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", equipment.CategoryId);
            ViewData["ConditionId"] = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName", equipment.ConditionId);
            return View(equipment);
        }

        // POST: Equipments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EquipmentId,EquipmentName,Description,CategoryId,RentalPricePerDay,Quantity,ConditionId,AvailabilityId")] Equipment equipment)
        {
            if (id != equipment.EquipmentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentExists(equipment.EquipmentId))
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
            ViewData["AvailabilityId"] = new SelectList(_context.AvailabilityStatuses, "AvailabilityId", "AvailabilityStatusName", equipment.AvailabilityId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", equipment.CategoryId);
            ViewData["ConditionId"] = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName", equipment.ConditionId);
            return View(equipment);
        }

        // GET: Equipments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Equipment == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipment
                .Include(e => e.Availability)
                .Include(e => e.Category)
                .Include(e => e.Condition)
                .FirstOrDefaultAsync(m => m.EquipmentId == id);
            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
        }

        // POST: Equipments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Equipment == null)
            {
                return Problem("Entity set 'LightAndLensDBContext.Equipment'  is null.");
            }
            var equipment = await _context.Equipment.FindAsync(id);
            if (equipment != null)
            {
                _context.Equipment.Remove(equipment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentExists(int id)
        {
          return (_context.Equipment?.Any(e => e.EquipmentId == id)).GetValueOrDefault();
        }
    }
}
