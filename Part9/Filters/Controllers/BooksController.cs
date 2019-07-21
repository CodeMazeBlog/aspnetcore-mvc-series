using Microsoft.AspNetCore.Mvc;
using Filters.Filters;
using Filters.Models;

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