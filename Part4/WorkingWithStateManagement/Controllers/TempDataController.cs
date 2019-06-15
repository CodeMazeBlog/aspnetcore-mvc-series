using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return View();
        }

        public IActionResult Third()
        { 
            return View();
        }
    }
}