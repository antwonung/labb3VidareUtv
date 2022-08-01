using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VidareUtveckla
{
    internal class HotWaterFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot water in your cup");
            return new Water();
        }
    }
}
