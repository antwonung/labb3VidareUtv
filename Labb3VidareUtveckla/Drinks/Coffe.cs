using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VidareUtveckla.Drinks
{
    internal class Coffe : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Coffe is served");
        }
    }
}
