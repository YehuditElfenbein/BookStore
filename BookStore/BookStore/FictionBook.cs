using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class FictionBook : Book
    {
        private string genre;

        public FictionBook(string title, string author, double price, string genre) : base(title, author, price)
        {
            this.genre = genre;
        }

        public override double CalculateDiscount()
        {
            return price * 0.1; // 10% discount for fiction books
        }
    }
}
