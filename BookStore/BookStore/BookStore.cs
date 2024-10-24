using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookStore
    {
        public static void Main(string[] args)
        {
            Book fictionBook = new FictionBook("Harry Potter", "J.K. Rowling", 20.0, "Fantasy");
            Book nonFictionBook = new NonFictionBook("Lean Startup", "Eric Ries", 30.0, "Business");

            Customer regularCustomer = new RegularCustomer("Alice");
            regularCustomer.BuyBook(fictionBook);
            regularCustomer.BuyBook(nonFictionBook);

            Customer premiumCustomer = new PremiumCustomer("Bob", "12345");
            premiumCustomer.BuyBook(fictionBook);

            Console.WriteLine("Regular Customer Purchased Books:");
            foreach (var book in regularCustomer.GetPurchasedBooks())
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.GetTitle()} by {book.GetAuthor()} - ${book.GetPrice()}");
                }
            }

            Console.WriteLine("Premium Customer Purchased Books:");
            foreach (var book in premiumCustomer.GetPurchasedBooks())
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.GetTitle()} by {book.GetAuthor()} - ${book.GetPrice()}");
                }
            }
        }
    }
    }
