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

        public Book()
        {

        }
        public Book (string ItemID)
        {

        }
        public Book (string ItemId, string Title)
        {

        }
        public Book (string ItemID, string Title, double Price)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
