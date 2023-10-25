using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    abstract public class Merchandise
    {
        public string ItemId { get; set; }
        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }

    }
}
