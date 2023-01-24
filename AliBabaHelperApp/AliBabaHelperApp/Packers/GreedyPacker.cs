using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliBabaHelperApp.Packers
{
    internal class GreedyPacker : IPacker
    {
        public Knapsack GetPackedKnapsack(int MaxWeight, int MaxVolume, List<Treasure> treasures)
        {
            Knapsack bag = new Knapsack(MaxWeight, MaxVolume);

            treasures.Sort((p, q) =>
            {
                if (p.Value / p.Weight + p.Volume > q.Value / q.Weight + q.Volume)
                {
                    return -1;
                }
                else if (p.Value / p.Weight + p.Volume  < q.Value / q.Weight + q.Volume)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });
             
            for(int i = 0; i < treasures.Count;i++)
            {
                if (bag.WillFit(treasures[i]))
                {
                    bag.Add(treasures[i]);
                }
            }

            return bag;
        }
    }
}
