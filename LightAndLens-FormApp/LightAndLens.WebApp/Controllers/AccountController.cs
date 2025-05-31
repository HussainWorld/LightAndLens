using Microsoft.AspNetCore.Mvc;

namespace LightAndLens.WebApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
    }
}


