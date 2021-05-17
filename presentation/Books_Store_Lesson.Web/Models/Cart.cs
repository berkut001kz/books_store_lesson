using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_Store_Lesson.Web.Models
{
    public class Cart
    {
        /// <summary>
        /// Тауардын id сақтаймыз және count сақтаймыз
        /// IDictionary<id, count> мысал
        /// </summary>
        public IDictionary<int, int> Items { get; set; } = new Dictionary<int, int>();

        public decimal Amount { get; set; }
    }
}
