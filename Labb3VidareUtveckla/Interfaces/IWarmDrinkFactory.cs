using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VidareUtveckla
{
    public interface IWarmDrinkFactory
    {
        IWarmDrink Prepare(int total);
    }
}
