using Microsoft.AspNetCore.Mvc;
using System;
using Filters.Filters;

namespace Filters.Controllers
{
    [CacheResource]
    public class CachedController : Controller
    {
        public IActionResult Index()
        {
            return Content("This content was generated at " + DateTime.Now);
        }
    }
}