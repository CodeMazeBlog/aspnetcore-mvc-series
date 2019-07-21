using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Filters.Filters;
using Filters.Models;

namespace Filters.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize("Read")]
        public IActionResult Read()
        {
            return View();
        }

        [Authorize("Write")]
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Login()
        {
            // Logic for authenticating the user goes here 

            // Once the user is successfully authenticated as admin, 
            // let's issue a claim of type = "Role" and value = "Admin" to the user

            var claims = new List<Claim>()
            {
                new Claim("Role", "Admin")
            };

            ClaimsIdentity identity = new ClaimsIdentity(claims);

            HttpContext.User.AddIdentity(identity);

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GenerateError()
        {
            throw new NotImplementedException();
        }

        [AddHeader]
        public IActionResult TestResultFilter()
        {
            return View();
        }
    }
}
