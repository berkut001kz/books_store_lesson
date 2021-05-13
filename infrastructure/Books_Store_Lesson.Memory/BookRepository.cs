using System;
using System.Linq;

namespace Books_Store_Lesson.Memory
{
    public class BookRepository : IBookRepository
    {
        /// <summary>
        /// Жаңа кітап қосамыз
        /// </summary>
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12345-54321","D. Knuth", "Art Of Programming"),
            new Book(2, "ISBN 12345-54322","M. Fowler", "Refactoring"),
            new Book(3, "ISBN 12345-54323","B. Kernighan, D. Ritchie", "C Programming Language"),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }


        /// <summary>
        /// Табылған кітаптарды қайтарады
        /// </summary>
        /// <param name="query">Іздеу сөзі</param>
        /// <returns>Тізбек - Array</returns>
        public Book[] GetAllByTitleOrAuthor(string query)
        {
            // Where(book => book.Title.Contains(titlePart)) - true немесе false қайтарады
            // Where(book => book.Title.Contains(titlePart)) - егер Programming сөзі біррет немесе оданда көп кезіксе true қайтарады
            // .ToArray(); - қайтадан тізбек түрінде қайтарады

            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }
    }
}


