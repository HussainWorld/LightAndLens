using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using LightAndLens.WebApp.Models;
using LightAndLens.WebApp.Identity;
using Microsoft.EntityFrameworkCore;
using LightAndLensCL.Models;
using Microsoft.AspNetCore.Authorization;

namespace LightAndLens.WebApp.Controllers
{
    [Authorize(Roles ="Admin")]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly LightAndLensDBContext _context;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, LightAndLensDBContext context)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _context = context;
        }

        // GET: Users/Create
        /* public async Task<IActionResult> Create()
         {
             var vm = new UserCreateViewModel
             {
                 Roles = await _roleManager.Roles
                     .Select(r => new SelectListItem { Text = r.Name, Value = r.Id })
                     .ToListAsync()
             };

             return View(vm);
         }
        */
        public async Task<IActionResult> Create()
        {
            try
            {
                var roles = await _roleManager.Roles.ToListAsync();
                var vm = new UserCreateViewModel
                {
                    Roles = roles.Select(r => new SelectListItem
                    {
                        Text = r.Name,
                        Value = r.Id
                    }).ToList()
                };

                return View(vm);
            }
            catch (Exception ex)
            {
                return Content("Failed to load roles: " + ex.Message);
            }
        }

        public async Task<IActionResult> Index()
        {
            var users = await _context.Users
                .Include(u => u.Role)
                .OrderBy(u => u.FullName)
                .ToListAsync();

            return View(users);
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserCreateViewModel model)
        {
            model.Roles = await _roleManager.Roles
                .Select(r => new SelectListItem { Text = r.Name, Value = r.Id })
                .ToListAsync();

            if (!ModelState.IsValid)
            {
                Console.WriteLine("[DEBUG] ModelState is invalid.");
                return View(model);
            }

            try
            {
                var identityRole = await _roleManager.FindByIdAsync(model.RoleId);
                if (identityRole == null)
                {
                    ModelState.AddModelError("RoleId", "Selected role not found.");
                    Console.WriteLine("[DEBUG] Role not found for RoleId: " + model.RoleId);
                    return View(model);
                }

                var identityUser = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,

                };

                var result = await _userManager.CreateAsync(identityUser, model.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        Console.WriteLine("[ERROR] Identity create error: " + error.Description);
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View(model);
                }

                await _userManager.AddToRoleAsync(identityUser, identityRole.Name);
                Console.WriteLine($"[DEBUG] Identity user created. ID: {identityUser.Id}, Email: {identityUser.Email}");

                var businessRole = await _context.Roles
                    .FirstOrDefaultAsync(r => r.RoleName == identityRole.Name);

                if (businessRole == null)
                {
                    Console.WriteLine("[ERROR] No matching business role found for: " + identityRole.Name);
                    ModelState.AddModelError(string.Empty, "Internal error: Role not found in business table.");
                    return View(model);
                }

                var businessUser = new User
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    PhoneNumber = int.TryParse(model.Phone, out var phone) ? phone : null,
                    RoleId = businessRole.RoleId,
                    IdentityUserId = identityUser.Id
                };

                _context.Users.Add(businessUser);
                Console.WriteLine("[DEBUG] Business user added to context. Calling SaveChanges...");

                await _context.SaveChangesAsync();
                Console.WriteLine("[DEBUG] SaveChangesAsync completed successfully. User inserted.");

                TempData["Success"] = "User created successfully.";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[ERROR] Exception: " + ex.Message);
                ModelState.AddModelError(string.Empty, "An error occurred: " + ex.Message);
                return View(model);
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(m => m.UserId == id);

            if (user == null) return NotFound();

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return RedirectToAction(nameof(Index));

            // Delete from Identity if linked
            if (!string.IsNullOrEmpty(user.IdentityUserId))
            {
                var identityUser = await _userManager.FindByIdAsync(user.IdentityUserId);
                if (identityUser != null)
                    await _userManager.DeleteAsync(identityUser);
            }

            // Delete from Users table
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            TempData["Success"] = "User deleted successfully.";
            return RedirectToAction(nameof(Index));
        }
    }







}
