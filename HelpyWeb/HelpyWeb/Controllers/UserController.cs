using Microsoft.AspNetCore.Mvc;

namespace HelpyWeb.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Friends()
        {
            return View();
        }
    }
}
