using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class PremiumCustomer : RegularCustomer
    {
        private string membershipId;

        public PremiumCustomer(string name, string membershipId) : base(name)
        {
            this.membershipId = membershipId;
        }

        public override void BuyBook(Book book)
        {
            double discountedPrice = book.GetPrice() - book.CalculateDiscount() - (book.GetPrice() * 0.05); // Extra 5% discount for premium customers
            book = new Book(book.GetTitle(), book.GetAuthor(), discountedPrice);
            base.BuyBook(book);
        }
    }
}
