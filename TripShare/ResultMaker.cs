using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class ResultMaker : IResultMaker
    {
        public List<string> PrepareResult(Dictionary<string, decimal> dict)
        {
            List<string> resultlist = new List<string>();

            foreach (var sample in dict)
            {
                string[] names = sample.Key.Split('_');
                resultlist.Add($"{names[0]} should return {names[1]} {String.Format("{0:.00}", sample.Value)}zł.");
            }

            return resultlist;
        }
    }
}
