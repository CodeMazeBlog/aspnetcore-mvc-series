using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WorkingWithViews.Models;

namespace BookStoreWithViews.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult Index()
        {
            IEnumerable<Book> books = GetBooks();
            return View(books);
        }

        // GET: Books/Details/5
        public ActionResult Details(int id)
        {
            Book book = GetBooks().ToList().FirstOrDefault(b => b.Id == id);
            return View(book);
        }

        // GET: Books/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Title,Genre,Price,PublishDate")] Book book)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(book);
            }
        }

        // GET: Books/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Books/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Books/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IEnumerable<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            Book book1 = new Book()
            {
                Id = 1,
                Title = "Learning ASP.NET Core 2.0",
                Genre = "Programming & Software Development",
                Price = 45,
                PublishDate = new System.DateTime(2017, 12, 14)                
            };

            books.Add(book1);

            Book book2 = new Book()
            {
                Id = 1,
                Title = "Pro ASP.NET Core MVC",
                Genre = "Programming & Software Development",
                Price = 85,
                PublishDate = new System.DateTime(2016, 09, 15),                
            };

            books.Add(book2);

            return books;
        }
    }
}