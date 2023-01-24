using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliBabaHelperApp.Packers
{
    internal class montecarlo : IPacker
    {
        public Knapsack GetPackedKnapsack(int MaxWeight, int MaxVolume, List<Treasure> treasures)
        {
            Knapsack bestBag = GetRandomlyFilledKnapsack(MaxWeight, MaxVolume, treasures);
            for (int i = 0; i <= 10000; i++)
            {
                Knapsack contenderBag = GetRandomlyFilledKnapsack(MaxWeight, MaxVolume, treasures);
                if (contenderBag.Value() > bestBag.Value()) {
                    bestBag = contenderBag; }
            }
            return bestBag;
        }
        private Knapsack GetRandomlyFilledKnapsack(int maxWeight, int maxVolume, List<Treasure> treasures)
        {
            Knapsack bag = new Knapsack(maxWeight, maxVolume);
            Random rnd = new Random();

            for (int i = 0; i < treasures.Count; i++)
            {
                if (rnd.Next() % 2 == 0)
                {

                    bag.Add(treasures[i]);

                }
            }
            return bag;
        }
    }
}
