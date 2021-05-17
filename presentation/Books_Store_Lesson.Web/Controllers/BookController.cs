using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Store_Lesson.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IActionResult Index(int id)
        {
            var book = bookRepository.GetById(id);

            return View(book);
        }
    }
}
