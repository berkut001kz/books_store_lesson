using System;
using System.Collections.Generic;
using System.Text;

namespace Books_Store_Lesson
{
    public class BookService
    {

        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public Book[] GetAllByQuery(string query)
        {
            if (Book.IsIsbn(query))
                return bookRepository.GetAllByIsbn(query);
            else
                return bookRepository.GetAllByTitleOrAuthor(query);
        }

        

    }
}
