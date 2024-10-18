using Microsoft.AspNetCore.Mvc;

namespace HelpyWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            ViewData["HideNavbar"] = true;
            return View();
        }
        public IActionResult Register()
        {
            ViewData["HideNavbar"] = true;
            return View();
        }
    }
}
