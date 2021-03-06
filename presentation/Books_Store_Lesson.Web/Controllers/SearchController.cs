using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Store_Lesson.Web.Controllers
{
    public class SearchController : Controller
    {
        private readonly BookService bookService;

        public SearchController(BookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index(string query)
        {
            //if (query == null || query == " ") return View("Index");

            var books = bookService.GetAllByQuery(query);
            return View(books);

            // Аңық түрде көрсету
            //return View("index", books);
        }
    }
}
