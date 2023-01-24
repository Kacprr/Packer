using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliBabaHelperApp.Packers
{
    public class FastPacker : IPacker
    {
        public Knapsack GetPackedKnapsack(int maxWeight, int maxVolume, List<Treasure> treasures)
        {
            Knapsack bag = new Knapsack(maxWeight, maxVolume);
            
            for(int i = 0; i <treasures.Count; i++)
            {
                if (bag.WillFit(treasures[i])){
                    bag.Add(treasures[i]);
                }
            }
            return bag;
        }
    }
}
