using System;
using System.Text.RegularExpressions;

namespace Books_Store_Lesson
{
    public class Book
    {
        #region Getters

        public int Id { get; }

        public string Isbn { get; }

        public string Author { get; }
        public string Title { get; }

        #endregion Getters

        #region Constructor

        public Book(int id,string isbn,string author, string title)
        {
            this.Id = id;
            this.Isbn = isbn;
            this.Author = author; 
            this.Title = title;
        }

        #endregion Constructor


        internal static bool IsIsbn(string s)
        {

            if (s == null) return false;
            s = s.Replace("-", "")
                .Replace(" ", "")
                .ToUpper();

            return Regex.IsMatch(s, "^ISBN\\d{10}(\\d{3})?$"); // Қайтаратын нәтижесі true егер осылай болса ISBN1234567890 кезгелген 10сан егер басқалай болған жағдайда false болады
            /*
             * "^ISBN\\d{10}(\\d{3})?$" - Осыған түсінік
             * ^ISBN - ISBN осы сөздін алдында басқа әріп болмауы керек
             * \\d{10} - деген нақты 10 сан болуы қажет дегені
             * (\\d{3})? - 10 саннаң көп болса тағы 3 саң болуы мүмкін дегенді білдіреді
             * \\d{10}(\\d{3})? - 10 сан немесе 13 болуы қажет деген сөз басқалай болмайды 
             * $ - соңында ештеме болмауы керек деген сөз
                */
        }

    }
}
