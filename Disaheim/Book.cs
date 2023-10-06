using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book
    {
        public string ItemId {  get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

      
        public Book (string itemId) : this(itemId, "")
        {
            ItemId = itemId;
        }
        public Book (string itemId, string title) : this(itemId, title, 0)
        {
            ItemId = itemId;
            Title = title;
        }
        public Book (string itemId, string title, double price)
        {
            ItemId= itemId;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
