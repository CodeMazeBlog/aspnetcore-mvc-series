using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
	public class BooksController : Controller
	{
		public IActionResult Create()
		{
			return View();
		}
	}
}