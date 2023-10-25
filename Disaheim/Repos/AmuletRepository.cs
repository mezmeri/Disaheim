using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim.Repos
{
    public class AmuletRepository
    {
        private Utility utility = new();
        private List<Amulet> amulets = new();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet? GetAmulet(string itemId)
        {
            return amulets.First(a => a.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (var amulet in amulets)
            {
                totalValue += utility.GetValueOfAmulet(amulet);
            }
            return totalValue;
        }
    }
}
