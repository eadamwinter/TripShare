using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TripShare
{
    public class CalculationMethod : ICalculationMethod
    {

        public Dictionary<string, decimal> CalculateMembersExpenses(Calculation calculation)
        {

            // Creating an empty dictionary which will be consequently filling with data about each expense from database
            Dictionary<string, decimal> MemberToMemberDict = new Dictionary<string, decimal>();
            IEnumerable<Expense> expenses = calculation.expenseRepository.GetAllExpenses(calculation.TableNumber);

            foreach(var expense in expenses)
            {
                decimal average = expense.Amount / (expense.NumberOfMembersInvolved+1);

                List<string> membersInvolved = expense.NamesOfMembersInvolved.Split(',').ToList();
                string member = expense.Name;

                for(byte i=0; i<expense.NumberOfMembersInvolved; i++)
                {
                    string Who_Whom = CreateStringForDictionary(membersInvolved, member, i);
                    
                    
                    
                    try
                    {
                        MemberToMemberDict.Add(Who_Whom, average);
                    }
                    catch (ArgumentException)
                    {
                        MemberToMemberDict[Who_Whom] += average;
                    }
                    
                }
                
            }
            return MemberToMemberDict;
        }

        // Creating a key for the dictionary -> name1 (person who owns money to person with name2), underline, name2
        public string CreateStringForDictionary(List<string> membersInvolved, string name, byte which)
        {
            return membersInvolved[which] + "_" + name;
        }

        // Optimizing dict by removing spare elements
        public Dictionary<string, decimal> OptimizeDict(Dictionary<string, decimal> dict)
        {
            List<string> keyList = dict.Keys.ToList();

            foreach (var key in keyList)
            {
                
                if(!dict.ContainsKey(key)) { continue; }
                string newkey = MakingOppositeKey(key);
                
                if(dict.ContainsKey(newkey))
                {
                    if (dict[key] == dict[newkey])
                    {
                        dict.Remove(key);
                        dict.Remove(newkey);
                    }
                    else if(dict[key]>dict[newkey])
                    {
                        dict[key] -= dict[newkey];
                        dict.Remove(newkey);
                    }
                    else if(dict[key]<dict[newkey])
                    {
                        dict[newkey] -= dict[key];
                        dict.Remove(key);
                    }
                }               
            }
            return dict;
        }

        public string MakingOppositeKey(string key)
        {
            string[] subs = key.Split('_');
            string newstring = subs[1] + "_" + subs[0];
            return newstring;
        }

    }
}
