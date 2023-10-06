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
        public string ItemID {  get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

      
        public Book (string itemID) : this(itemID, "")
        {

        }
        public Book (string itemID, string title) : this(itemID, title, 0)
        {

        }
        public Book (string itemID, string title, double price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
