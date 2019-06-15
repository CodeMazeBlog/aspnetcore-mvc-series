using Microsoft.AspNetCore.Mvc;

namespace WorkingWithStateManagement.Controllers
{
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {
            ViewData["UserId"] = 101;
            return View();
        }
    }
}