using LightAndLens.WebApp.Models;
using LightAndLensCL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LightAndLens.WebApp.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly LightAndLensDBContext _context;
        private readonly Services.LogHelper _logHelper;

        public FeedbackController(LightAndLensDBContext context, Services.LogHelper logHelper)
        {
            _context = context;
            _logHelper = logHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Create(int returnId)
        {
            // Load the return record details to show (optional)
            var returnRecord = await _context.ReturnRecords
                .Include(r => r.Rental)
                    .ThenInclude(rt => rt.Request)
                        .ThenInclude(req => req.Equipment)
                .Include(r => r.Rental.User)
                .FirstOrDefaultAsync(r => r.ReturnId == returnId);

            if (returnRecord == null)
                return NotFound();

            var vm = new FeedbackViewModel
            {
                ReturnId = returnId,
                EquipmentName = returnRecord.Rental.Request.Equipment.EquipmentName,
                CustomerName = returnRecord.Rental.User.FullName,
            };

            return View(vm);
        }

        // POST: Feedback/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> Create(FeedbackViewModel model)
        {

            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            if (errors.Any())
            {
                // Log or debug breakpoint here to see errors
                // For example:
                foreach (var error in errors)
                {
                    Console.WriteLine("Validation error: " + error);
                }
            }

            var errorss = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            foreach (var error in errors)
            {
                Console.WriteLine($"Validation error: {error}");
            }

            if (!ModelState.IsValid)
            {
                var returnRecord = await _context.ReturnRecords
                    .Include(r => r.Rental)
                        .ThenInclude(rt => rt.Request)
                            .ThenInclude(req => req.Equipment)
                    .Include(r => r.Rental.User)
                    .FirstOrDefaultAsync(r => r.ReturnId == model.ReturnId);

                if (returnRecord != null)
                {
                    model.EquipmentName = returnRecord.Rental.Request.Equipment.EquipmentName;
                    model.CustomerName = returnRecord.Rental.Request.User.FullName;
                    
                }

                return View(model);
            }

            var identityId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _context.Users.FirstOrDefaultAsync(u => u.IdentityUserId == identityId);
            if (user == null)
                return Unauthorized();

            var returnRecordEntity = await _context.ReturnRecords
    .Include(r => r.Rental)
        .ThenInclude(rt => rt.Request)
    .FirstOrDefaultAsync(r => r.ReturnId == model.ReturnId);
            if (returnRecordEntity == null)
                return NotFound();

            var feedback = new Feedback
            {
                UserId = user.UserId,
                EquipmentId = returnRecordEntity.Rental.Request.EquipmentId,
                ReturnId = model.ReturnId,
                Rating = model.Rating,
                Comments = model.Comments ?? "",

            };

            _context.Feedbacks.Add(feedback);

            // Update return status here or leave it for admin review
            returnRecordEntity.ConditionStatus = "Pending";

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", "ReturnRecords");
        }

    }
}
