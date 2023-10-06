using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{

    internal class Amulet
    {
        public string ItemID { get; set; }
        public string Design {  get; set; }
        public Level Quality {  get; set; }

        public Amulet()
        {

        }
        public Amulet(string ItemID)
        {

        }
        public Amulet(string ItemID, Level Quality)
        {

        }
        public Amulet (string ItemID, Level quality, string design)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
