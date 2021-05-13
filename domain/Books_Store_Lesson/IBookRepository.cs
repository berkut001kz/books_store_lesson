using System;
using System.Collections.Generic;
using System.Text;

namespace Books_Store_Lesson
{
    // Interface - неге құрдық
    // Біз сақтау орны әдісін жасамадық сондықтан
    // Белгісіз болған жағдайда Interface қажет
    public interface IBookRepository
    {
        Book[] GetAllByIsbn(string isbn);
        Book[] GetAllByTitleOrAuthor(string titleOrAuthor);
    }
}
