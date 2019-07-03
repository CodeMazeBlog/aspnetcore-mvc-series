using Microsoft.AspNetCore.Mvc;

namespace WorkingWithDI.Controllers
{
	public class BooksController : Controller
	{
		public IActionResult Create()
		{
			return View();
		}
	}
}