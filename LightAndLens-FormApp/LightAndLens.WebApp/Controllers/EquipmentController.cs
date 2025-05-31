using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using LightAndLens.WebApp.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace LightAndLens.WebApp.Controllers
{
    [Authorize]
    public class EquipmentController : Controller
    {
        private readonly LightAndLensDBContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly LogHelper _logHelper;

        public EquipmentController(LightAndLensDBContext context, IWebHostEnvironment webHostEnvironment, LogHelper logHelper)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _logHelper = logHelper;
        }

        // GET: Equipments
        public async Task<IActionResult> Index(string searchString, int? categoryId, int? availabilityId, int? conditionId)
        {
            var query = _context.Equipment
                .Include(e => e.Availability)
                .Include(e => e.Category)
                .Include(e => e.Condition)
                .Include(e => e.EquipmentImages)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                query = query.Where(e => e.EquipmentName.Contains(searchString));
            }

            if (categoryId.HasValue)
            {
                query = query.Where(e => e.CategoryId == categoryId);
            }

            if (availabilityId.HasValue)
            {
                query = query.Where(e => e.AvailabilityId == availabilityId);
            }

            if (conditionId.HasValue)
            {
                query = query.Where(e => e.ConditionId == conditionId);
            }

            var equipmentList = await query.ToListAsync();

            // Pass dropdowns to view
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewBag.Statuses = new SelectList(_context.AvailabilityStatuses, "AvailabilityId", "AvailabilityStatusName");
            ViewBag.Conditions = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName");

            // Log the action
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            if (user != null)
            {
                await _logHelper.LogActionAsync(user.UserId, "Viewed Equipment List");
            }

            return View(equipmentList);
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
                .Include(e => e.EquipmentImages)
                .FirstOrDefaultAsync(m => m.EquipmentId == id);
            if (equipment == null)
            {
                return NotFound();
            }

            // Log the action
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            if (user != null)
            {
                await _logHelper.LogActionAsync(user.UserId, $"Viewed Equipment: {equipment.EquipmentName}");
            }

            return View(equipment);
        }

        // GET: Equipments/Create
        [Authorize(Roles = "Admin,Staff")]
        public IActionResult Create()
        {
            ViewData["AvailabilityId"] = new SelectList(_context.AvailabilityStatuses, "AvailabilityId", "AvailabilityStatusName");
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["ConditionId"] = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName");
            return View();
        }

        // POST: Equipments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Staff")]
        public async Task<IActionResult> Create([Bind("EquipmentId,EquipmentName,Description,CategoryId,RentalPricePerDay,Quantity,ConditionId,AvailabilityId")] Equipment equipment, IFormFile imageFile)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipment);
                await _context.SaveChangesAsync(); // Save first to get EquipmentId

                if (imageFile != null && imageFile.Length > 0)
                {
                    var sharedImagePath = Path.Combine("..", "SharedImages");
                    var fileName = $"equipment_{equipment.EquipmentId}_{Path.GetFileName(imageFile.FileName)}";
                    var filePath = Path.Combine(sharedImagePath, fileName);

                    Directory.CreateDirectory(sharedImagePath); // Ensure folder exists

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(stream);
                    }

                    var equipmentImage = new EquipmentImage
                    {
                        EquipmentId = equipment.EquipmentId,
                        ImagePath = fileName,
                        IsMain = true
                    };

                    _context.EquipmentImages.Add(equipmentImage);
                    await _context.SaveChangesAsync();
                }
                // Log the action
                var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

                if (user != null)
                {
                    await _logHelper.LogActionAsync(user.UserId, $"Created New Equipment: {equipment.EquipmentName}");
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["AvailabilityId"] = new SelectList(_context.AvailabilityStatuses, "AvailabilityId", "AvailabilityStatusName", equipment.AvailabilityId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", equipment.CategoryId);
            ViewData["ConditionId"] = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName", equipment.ConditionId);
            return View(equipment);
        }

        // GET: Equipments/Edit/5
        [Authorize(Roles = "Admin,Staff")]
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", equipment.CategoryId);
            ViewData["ConditionId"] = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName", equipment.ConditionId);
            return View(equipment);
        }

        // POST: Equipments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Staff")]
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
                    // Log the action
                    var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                    var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

                    if (user != null)
                    {
                        await _logHelper.LogActionAsync(user.UserId, $"Edited Equipment: {equipment.EquipmentName}");
                    }
                    // Redirect to Index after successful edit
                    return RedirectToAction(nameof(Index));
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
            }


            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    Console.WriteLine($" Field: {state.Key}, Error: {error.ErrorMessage}");
                }
            }

            // Refill dropdowns for the view if validation fails
            ViewData["AvailabilityId"] = new SelectList(_context.AvailabilityStatuses, "AvailabilityId", "AvailabilityStatusName", equipment.AvailabilityId);
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", equipment.CategoryId);
            ViewData["ConditionId"] = new SelectList(_context.ConditionStatuses, "ConditionId", "ConditionName", equipment.ConditionId);

            return View(equipment);
        }

        // GET: Equipments/Delete/5
        [Authorize(Roles = "Admin,Staff")]
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
        [Authorize(Roles = "Admin,Staff")]
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

            if (equipment.EquipmentImages != null)
                _context.EquipmentImages.RemoveRange(equipment.EquipmentImages);

            await _context.SaveChangesAsync();
            // Log the action
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            if (user != null)
            {
                await _logHelper.LogActionAsync(user.UserId, $"Deleted Equipment: {equipment.EquipmentName}");
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Search(string searchString, int? categoryId, int? availabilityId, int? conditionId)
        {
            var query = _context.Equipment
                .Include(e => e.Category)
                .Include(e => e.Condition)
                .Include(e => e.Availability)
                .Include(e => e.EquipmentImages)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchString))
                query = query.Where(e => e.EquipmentName.Contains(searchString));

            if (categoryId.HasValue)
                query = query.Where(e => e.CategoryId == categoryId);

            if (availabilityId.HasValue)
                query = query.Where(e => e.AvailabilityId == availabilityId);

            if (conditionId.HasValue)
                query = query.Where(e => e.ConditionId == conditionId);

            var filtered = query.ToList();
            return PartialView("_EquipmentListPartial", filtered);
        }

        private bool EquipmentExists(int id)
        {
            return (_context.Equipment?.Any(e => e.EquipmentId == id)).GetValueOrDefault();
        }
    }
}
