using System.Collections.Generic;
using BookHaven.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookHaven.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to Book Haven! Your cozy corner for literature.";
            return View();
        }

        public ActionResult Books()
        {
            var books = new List<Book>
            {
                new Book { Title = "1984", Author = "George Orwell", Year = 1949 },
                new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937 },
                new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 }
            };

            return View(books);
        }
    }
}
