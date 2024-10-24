using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class RegularCustomer : Customer
    {
        private string name;
        private Book[] purchasedBooks = new Book[50];
        private int booksCount = 0;

        public RegularCustomer(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public virtual void BuyBook(Book book)
        {
            purchasedBooks[booksCount] = book;
            booksCount++;
        }

        public Book[] GetPurchasedBooks()
        {
            return purchasedBooks;
        }
    }
}
