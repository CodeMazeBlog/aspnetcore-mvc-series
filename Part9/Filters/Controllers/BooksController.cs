using Filters.Filters;
using Filters.Models;
using Microsoft.AspNetCore.Mvc;

namespace Filters.Controllers
{
	public class BooksController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Create()
		{
			return View();
		}

		[ValidateModel]
		[HttpPost]
		public IActionResult Create([FromBody]Book book)
		{
			return View();
		}
	}
}