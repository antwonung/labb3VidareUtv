using Labb3VidareUtveckla.Drinks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VidareUtveckla
{
    internal class HotCoffeFactory : IWarmDrinkFactory
    {
        public IWarmDrink Prepare(int total)
        {
            Console.WriteLine($"Pour {total} ml hot coffe in your cup");
            return new Coffe();
        }
    }
}
