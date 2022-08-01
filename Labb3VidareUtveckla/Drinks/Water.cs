using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VidareUtveckla
{
    internal class Water : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Warm water is served.");
        }
    }
}
