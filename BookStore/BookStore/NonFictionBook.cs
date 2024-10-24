using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class NonFictionBook : Book
    {
        private string topic;

        public NonFictionBook(string title, string author, double price, string topic) : base(title, author, price)
        {
            this.topic = topic;
        }

        public override double CalculateDiscount()
        {
            return price * 0.05; // 5% discount for non-fiction books
        }
    }

}
