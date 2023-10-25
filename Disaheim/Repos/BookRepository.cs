using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim.Repos
{
    public class BookRepository
    {
        private Utility utility = new();
        private List<Book> books = new();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book? GetBook(string itemId)
        {
            return books.First(b => b.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (var book in books)
            {
                totalValue += utility.GetValueOfBook(book);
            }
            return totalValue;
        }
    }
}
