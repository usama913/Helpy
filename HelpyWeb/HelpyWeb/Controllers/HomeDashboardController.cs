using Microsoft.AspNetCore.Mvc;

namespace HelpyWeb.Controllers
{
    public class HomeDashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
