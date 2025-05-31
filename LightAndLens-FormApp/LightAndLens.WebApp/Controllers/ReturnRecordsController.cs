using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using System.Security.Claims;
using LightAndLens.WebApp.Models;
using Microsoft.AspNetCore.Authorization;
using LightAndLens.WebApp.Services;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace LightAndLens.WebApp.Controllers
{
    public class ReturnRecordsController : Controller
    {
        private readonly LightAndLensDBContext _context;
        private readonly LogHelper _logHelper;
        public ReturnRecordsController(LightAndLensDBContext context, LogHelper logHelper)
        {
            _context = context;
            _logHelper = logHelper;
        }


        public async Task<IActionResult> Index(string condition, DateTime? startDate, DateTime? endDate, string search)
        {
            // Identify logged-in user
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            var query = _context.ReturnRecords
                .Include(r => r.Rental)
                    .ThenInclude(t => t.User)
                .Include(r => r.Rental)
                    .ThenInclude(t => t.Request)
                        .ThenInclude(req => req.Equipment)
                .AsQueryable();

            // If Customer, limit to their returns
            if (User.IsInRole("Customer") && currentUser != null)
            {
                query = query.Where(r => r.Rental.UserId == currentUser.UserId);
            }

            // Filter: Condition Status
            if (!string.IsNullOrEmpty(condition))
            {
                query = query.Where(r => r.ConditionStatus == condition);
            }
            
            // Filter: Return Date range
            if (startDate.HasValue)
                query = query.Where(r => r.ReturnDate >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(r => r.ReturnDate <= endDate.Value);

            // Filter: Renter Full Name
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(r => r.Rental.User.FullName.Contains(search));
            }

            // Optional: project to ViewModel later, for now return the full model
            var results = await query.ToListAsync();

            return View(results);
        }


        public async Task<IActionResult> Review()
        {
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            var allReturns = _context.ReturnRecords
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.User)
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.Request)
                        .ThenInclude(req => req.Equipment)
                         .Include(r => r.Feedbacks)
                .AsQueryable();

            // Restrict for customer
            if (User.IsInRole("Customer") && currentUser != null)
            {
                allReturns = allReturns.Where(r => r.Rental.UserId == currentUser.UserId);
            }

            // Dropdowns
            var availabilityOptions = await _context.AvailabilityStatuses
                .Select(a => new SelectListItem { Value = a.AvailabilityId.ToString(), Text = a.AvailabilityStatusName })
                .ToListAsync();

            var conditionOptions = await _context.ConditionStatuses
                .Select(c => new SelectListItem { Value = c.ConditionId.ToString(), Text = c.ConditionName })
                .ToListAsync();

            // PENDING = "Pending" status
            var pending = await allReturns
                .Where(r => r.ConditionStatus == "Pending")
                .Select(r => new ReturnRecordViewModel
                {
                    ReturnId = r.ReturnId,
                    RentalId = r.RentalId,
                    EquipmentName = r.Rental.Request.Equipment.EquipmentName,
                    RentedBy = r.Rental.User.FullName,
                    ReturnDate = r.ReturnDate,
                    ConditionStatus = r.ConditionStatus,
                    Notes = r.Notes,
                    ConditionOptions = conditionOptions,
                    AvailabilityOptions = availabilityOptions,

                    // Map feedback if exists (assuming one feedback per return per user)
                    CustomerFeedback = r.Feedbacks.Select(f => new FeedbackViewModel
                    {
                        Rating = f.Rating,
                        Comments = f.Comments,
                        CustomerName = f.User.FullName // Add FullName to FeedbackViewModel if needed
                    }).FirstOrDefault()
                }).ToListAsync();

            // HISTORY = everything else
            var history = await allReturns
                .Where(r => r.ConditionStatus != "Pending")
                .Select(r => new ReturnRecordViewModel
                {
                    ReturnId = r.ReturnId,
                    RentalId = r.RentalId,
                    EquipmentName = r.Rental.Request.Equipment.EquipmentName,
                    RentedBy = r.Rental.User.FullName,
                    ReturnDate = r.ReturnDate,
                    ConditionStatus = r.ConditionStatus,
                    Notes = r.Notes
                }).ToListAsync();

            var vm = new ReturnRecordViewModel
            {
                PendingReturns = pending,
                HistoryReturns = history
            };

            return View("Review", vm);
        }



        // GET: ReturnRecords/Finalize/5
        [HttpPost]
        [Authorize(Roles = "Admin,Staff")]
        public async Task<IActionResult> FinalizeReturn(int ReturnId, int SelectedConditionId, int SelectedAvailabilityId, string Notes)
        {
            var returnRecord = await _context.ReturnRecords
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.Request)
                .ThenInclude(req => req.Equipment)
                .FirstOrDefaultAsync(r => r.ReturnId == ReturnId);

            if (returnRecord == null || returnRecord.Rental?.Request?.Equipment == null)
                return NotFound();

            // Update return record
            var conditionStatus = await _context.ConditionStatuses
                .FirstOrDefaultAsync(c => c.ConditionId == SelectedConditionId);

            if (conditionStatus != null)
            {
                returnRecord.ConditionStatus = conditionStatus.ConditionName;
            }

            returnRecord.Notes = Notes ?? "No notes";
            returnRecord.ReturnDate = DateTime.Now;

            // Update equipment availability and condition
            var equipment = returnRecord.Rental.Request.Equipment;
            equipment.AvailabilityId = SelectedAvailabilityId;
            equipment.ConditionId = SelectedConditionId;

            await _context.SaveChangesAsync();

            // Get current staff user for logging
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            if (user != null)
            {
                await _logHelper.LogActionAsync(user.UserId, $"Processed return #{ReturnId} and updated equipment #{equipment.EquipmentId}");
            }

            TempData["Success"] = "Return finalized successfully.";
            return RedirectToAction("Review");
        }





        // GET: ReturnRecords/Search
        [HttpGet]
        public async Task<IActionResult> Search(string condition, DateTime? startDate, DateTime? endDate, string search)
        {
            // Get current logged-in user
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            // Base query with includes
            var query = _context.ReturnRecords
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.User)
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.Request)
                        .ThenInclude(req => req.Equipment)
                .AsQueryable();

            // Restrict to current user if customer
            if (User.IsInRole("Customer") && currentUser != null)
            {
                query = query.Where(r => r.Rental.UserId == currentUser.UserId);
            }

            // Filter by condition
            if (!string.IsNullOrEmpty(condition))
            {
                query = query.Where(r => r.ConditionStatus == condition);
            }

            // Filter by return date range
            if (startDate.HasValue)
                query = query.Where(r => r.ReturnDate >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(r => r.ReturnDate <= endDate.Value);

            // Filter by renter name
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(r => r.Rental.User.FullName.Contains(search));
            }

            var filteredResults = await query.ToListAsync();

            return PartialView("_ReturnPartial", filteredResults);
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

        [HttpGet]
        public async Task<IActionResult> SubmitFeedback(int returnId)
        {
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            var returnRecord = await _context.ReturnRecords
                .Include(r => r.Rental)
                .ThenInclude(rt => rt.User)
                .Include(r => r.Rental)
                .ThenInclude(rt => rt.Request)
                .ThenInclude(req => req.Equipment)
                .FirstOrDefaultAsync(r => r.ReturnId == returnId);

            if (returnRecord == null || currentUser == null || returnRecord.Rental.UserId != currentUser.UserId)
            {
                return Unauthorized();
            }

            // Check if feedback already exists for this return
            var existingFeedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.ReturnId == returnId && f.UserId == currentUser.UserId);

            var model = new FeedbackViewModel
            {
                ReturnId = returnRecord.ReturnId,
                EquipmentName = returnRecord.Rental.Request.Equipment.EquipmentName,
                RentalId = returnRecord.RentalId,
                Rating = existingFeedback?.Rating ?? 0,
                Comments = existingFeedback?.Comments
            };

            return View(model);



        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitFeedback(FeedbackViewModel model)
        {
            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);

            if (currentUser == null)
                return Unauthorized();

            var returnRecord = await _context.ReturnRecords.FindAsync(model.ReturnId);
            if (returnRecord == null || returnRecord.Rental.UserId != currentUser.UserId)
                return Unauthorized();

            // Check for existing feedback to update or create new
            var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.ReturnId == model.ReturnId && f.UserId == currentUser.UserId);

            if (feedback == null)
            {
                feedback = new Feedback
                {
                    ReturnId = model.ReturnId,
                    UserId = currentUser.UserId,
                    EquipmentId = returnRecord.Rental.Request.EquipmentId,
                    Rating = model.Rating,
                    Comments = model.Comments
                };
                _context.Feedbacks.Add(feedback);
            }
            else
            {
                feedback.Rating = model.Rating;
                feedback.Comments = model.Comments;
                _context.Feedbacks.Update(feedback);
            }

            // Optionally update return record status here
            returnRecord.ConditionStatus = "Pending"; // or "Feedback Submitted"
            await _context.SaveChangesAsync();

            TempData["Success"] = "Thank you for your feedback!";
            return RedirectToAction("Index");
        }
    }
}
