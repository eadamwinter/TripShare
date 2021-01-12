using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface IOptymizer
    {
        Dictionary<string, decimal> OptimizeDict(Dictionary<string, decimal> dict);
    }
}
