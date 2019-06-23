using Microsoft.AspNetCore.Mvc;

namespace WorkingWithRouting.Controllers
{
    public class BooksController : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Details/{id:int}")]
        public IActionResult Details(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}