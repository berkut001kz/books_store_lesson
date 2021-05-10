using System;

namespace Books_Store_Lesson
{
    public class Book
    {
        #region Getters

        public int Id { get; }
        public string Title { get; }

        #endregion Getters

        #region Constructor

        public Book(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }

        #endregion Constructor

    }
}
