using Labb3VidareUtveckla.Drinks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VidareUtveckla.Factorys
{
    internal class HotCappuccinoFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot cappuccino in your cup");
            return new Cappuccino();
        }
    }
}
