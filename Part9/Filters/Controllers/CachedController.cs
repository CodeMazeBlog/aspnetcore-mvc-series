using System;
using Filters.Filters;
using Microsoft.AspNetCore.Mvc;

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