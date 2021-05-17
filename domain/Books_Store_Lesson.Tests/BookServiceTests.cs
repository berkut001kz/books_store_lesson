using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Books_Store_Lesson.Tests
{
    public class BookServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithIsbn_CalsGetAllByIsbn()
        {
            var bookRepositoryStup = new Mock<IBookRepository>();
            bookRepositoryStup.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
                              .Returns(new[] { new Book(1, "", "", "", "", 0m)});

            bookRepositoryStup.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                              .Returns(new[] { new Book(2, "", "", "", "", 0m) });

            var bookService = new BookService(bookRepositoryStup.Object);
             
            var actual = bookService.GetAllByQuery("ISBN 12345-67890");
            Assert.Collection(actual, book => Assert.Equal(1, book.Id));
        }

        [Fact]
        public void GetAllByQuery_WithIsbn_CalsGetAllByTitleOrAuthor()
        {
            var bookRepositoryStup = new Mock<IBookRepository>();
            bookRepositoryStup.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
                              .Returns(new[] { new Book(1, "", "", "", "", 0m) });

            bookRepositoryStup.Setup(x => x.GetAllByTitleOrAuthor(It.IsAny<string>()))
                              .Returns(new[] { new Book(2, "", "", "", "", 0m) });

            var bookService = new BookService(bookRepositoryStup.Object);

            var actual = bookService.GetAllByQuery("12345-67890");
            Assert.Collection(actual, book => Assert.Equal(2, book.Id));
        }
    }
}
