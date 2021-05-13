using System;
using Xunit;

namespace Books_Store_Lesson.Tests
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse() // Null болса false қайтаруы қажет
        {
            bool actual = Book.IsIsbn(null);
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithBlankString_ReturnFalse() // Бос өріс болса false қайтаруы қажет
        {
            bool actual = Book.IsIsbn("  ");
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithInvalidIsbn_ReturnFalse() // Isbn Invalid болса false қайтаруы қажет
        {
            bool actual = Book.IsIsbn("ISBN 123");// Мысалы: Ол ISBN деп басталады бірақ 10 немесе 11 сан болмаса
            Assert.False(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn10_ReturnTrue() // Isbn 10сан болса true қайтаруы қажет
        {
            //Isbn деген сөз кіші әріппен жазылсада үлкен әріппен жазылсада бәрі-бір бастысы Isbn деп басталуы қажет
            //және 10сан болуы керек 
            // егер солай болса онда True қайтаруы қажет
            bool actual = Book.IsIsbn("ISBN 123-456-789 0");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithIsbn13_ReturnTrue() // Isbn 13сан болса true қайтаруы қажет
        {
            //Isbn деген сөз кіші әріппен жазылсада үлкен әріппен жазылсада бәрі-бір бастысы Isbn деп басталуы қажет
            //және 10сан болуы керек 
            // егер солай болса онда True қайтаруы қажет
            bool actual = Book.IsIsbn("ISBN 123-456-789 0123");
            Assert.True(actual);
        }

        [Fact]
        public void IsIsbn_WithTrashStart_ReturnFalse()
        {
            bool actual = Book.IsIsbn("yyy ISBN 123-456-789 0123 yyy");
            Assert.False(actual);
        }
    }
}
