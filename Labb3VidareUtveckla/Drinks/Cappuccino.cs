using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VidareUtveckla.Drinks
{
    internal class Cappuccino : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Cappuccino is served");
        }
    }
}
