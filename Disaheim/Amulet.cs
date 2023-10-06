using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{

    public class Amulet
    {
        public string ItemID { get; set; }
        public string Design {  get; set; }
        public Level Quality {  get; set; }

        
        public Amulet(string itemID) : this(itemID, Level.medium)
        {

        }
        public Amulet(string itemID, Level Quality) : this(itemID, Level.medium, "")
        {

        }
        public Amulet (string itemID, Level quality, string design)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
