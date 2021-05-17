using Books_Store_Lesson.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Store_Lesson.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IBookRepository bookRepository;

        public CartController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IActionResult Add(int id)
        {
            var book = bookRepository.GetById(id);
            Cart cart;
            if (!HttpContext.Session.TryGetCart(out cart))
                cart = new Cart();
            //Егер бір кітап бірнеше рет себетке қосылса онда оның бағасы мен саның арттырамыз
            if (cart.Items.ContainsKey(id))
                cart.Items[id]++;
            else
                cart.Items[id] = 1;

            cart.Amount += book.Price;

            //Session-ны сақтаймыз
            HttpContext.Session.Set(cart);

            //Келген бетке қайта жіберу
            return RedirectToAction("Index", "Book", new { id });
        }
    }
}
