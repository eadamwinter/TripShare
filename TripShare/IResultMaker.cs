using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface IResultMaker
    {
        List<string> PrepareResult(Dictionary<string, decimal> dict);
    }
}
