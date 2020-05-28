using Microsoft.AspNetCore.Mvc;

namespace WorkingWithStateManagement.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult First()
        {
            TempData["UserId"] = 101;
            return View();
        }

        public IActionResult Second()
        {
            var userId = TempData["UserId"] ?? null;
            return View();
        }

        public IActionResult Third()
        {
            var userId = TempData["UserId"] ?? null;
            return View();
        }
    }
}