using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            Book book = new Book()
            {
                Id = 1,
                Title = "Learning ASP.NET Core 2.0",
                Genre = "Programming & Software Development",
                Price = 45,
                PublishDate = new System.DateTime(2012, 04, 23),
                Authors = new List<string> { "Jason De Oliveira", "Michel Bruchet" }
            };

            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                // Logic to add the book to DB
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }
}