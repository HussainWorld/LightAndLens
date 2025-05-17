using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LightAndLens.WebApp.Identity;
using LightAndLensCL.Models;

namespace LightAndLens.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class LogsController : Controller
    {
        private readonly LightAndLensDBContext _context;

        public LogsController(LightAndLensDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var logs = await _context.Logs
                .Include(l => l.User)
                .OrderByDescending(l => l.Timestamp)
                .ToListAsync();

            return View(logs);
        }
    }
}


