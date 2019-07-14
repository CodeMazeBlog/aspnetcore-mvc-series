using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkingWithStateManagement.Models;

namespace WorkingWithStateManagement.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "John");
            HttpContext.Session.SetInt32("Age", 32);

            return View();
        }

        public IActionResult Get()
        {
            User newUser = new User()
            {
                Name = HttpContext.Session.GetString("Name"),
                Age = HttpContext.Session.GetInt32("Age").Value
            };

            return View(newUser);
        }

        public IActionResult GetQueryString(string name, int age)
        {
            User newUser = new User()
            {
                Name = name,
                Age = age
            };
            return View(newUser);
        }

        [HttpGet]
        public IActionResult SetHiddenFieldValue()
        {
            User newUser = new User()
            {
                Id = 101,
                Name = "John",
                Age = 31
            };
            return View(newUser);
        }

        [HttpPost]
        public IActionResult SetHiddenFieldValue(IFormCollection keyValues)
        {
            var id = keyValues["Id"];
            return View();
        }
    } 
}