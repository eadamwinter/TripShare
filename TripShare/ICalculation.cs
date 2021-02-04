using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface ICalculation
    {
        Dictionary<string, decimal> CalculateShare(byte tableNumber);
    }
}
