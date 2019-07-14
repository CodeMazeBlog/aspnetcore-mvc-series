using Microsoft.AspNetCore.Mvc;

namespace WorkingWithStateManagement.Controllers
{
    public class ViewBagController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserId = 101;
            ViewBag.Name = "John";
            ViewBag.Age = 31;

            return View();
        }
    }
}