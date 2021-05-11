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
            new Book(1,"Art Of Programming"),
            new Book(2,"Refactoring"),
            new Book(3,"C Programming Language"),
        };


        /// <summary>
        /// Табылған кітаптарды қайтарады
        /// </summary>
        /// <param name="titlePart">Іздеу сөзі</param>
        /// <returns>Тізбек - Array</returns>
        public Book[] GetAllByTitle(string titlePart)
        {
            // Where(book => book.Title.Contains(titlePart)) - true немесе false қайтарады
            // Where(book => book.Title.Contains(titlePart)) - егер Programming сөзі біррет немесе оданда көп кезіксе true қайтарады
            // .ToArray(); - қайтадан тізбек түрінде қайтарады

            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
        }
    }
}
