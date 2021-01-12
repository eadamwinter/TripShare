using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TripShare
{
    public class Optimizer : IOptymizer
    {
        public Dictionary<string, decimal> OptimizeDict(Dictionary<string, decimal> dict)
        {
            List<string> keylist = dict.Keys.ToList();
            foreach(var key in keylist)
            {
                if(!dict.ContainsKey(key)) { continue; }

                string[] subkey = key.Split('_');
                foreach(var otherkey in keylist)
                {

                    if(otherkey == key) { continue; }
                    if(!dict.ContainsKey(otherkey)) { continue; }

                    string[] subotherkey = otherkey.Split('_');
                    if(subkey[1] == subotherkey[0])
                    {
                        string testkey = subkey[0] + "_" + subotherkey[1];
                        if(dict.ContainsKey(testkey))
                        {
                            if (dict[key] < dict[otherkey])
                            {
                                dict[testkey] += dict[key];
                                dict[otherkey] -= dict[key];
                                dict.Remove(key);
                                break;
                            }
                            if (dict[key]==dict[otherkey])
                            {
                                dict[testkey] += dict[otherkey];
                                dict.Remove(otherkey);
                                dict.Remove(key);
                                break;
                            }
                        }
                    }
                }
            }
            return dict;
        }
    }
}
