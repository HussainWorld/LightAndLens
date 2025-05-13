using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using LightAndLens.WebApp.Models;
using LightAndLens.WebApp.Identity;
using Microsoft.EntityFrameworkCore;

namespace LightAndLens.WebApp.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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
                return View(model);
            }

            try
            {
                var role = await _roleManager.FindByIdAsync(model.RoleId);
                if (role == null)
                {
                    ModelState.AddModelError("RoleId", "Selected role not found.");
                    return View(model);
                }

                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    FullName = model.FullName,
                    PhoneNumber = model.Phone
                };

                var result = await _userManager.CreateAsync(user, "test123"); // Default password (can be updated later)

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);

                    return View(model);
                }

                await _userManager.AddToRoleAsync(user, role.Name);

                TempData["Success"] = "User created successfully.";
                return RedirectToAction("Create");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, "An error occurred: " + ex.Message);
                return View(model);
            }
        }
    }







}
