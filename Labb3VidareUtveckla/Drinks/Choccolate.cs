using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VidareUtveckla.Drinks
{
    internal class Choccolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Choccolate is served");
        }
    }
}
