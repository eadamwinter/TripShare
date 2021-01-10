using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class CalculationMethod : ICalculationMethod
    {

        public Dictionary<string, decimal> CalculateMembersExpenses(Calculation calculation)
        {

            //Utworzenie slownika(pustego) ktory bedzie stopniowo zapelniany danymi
            Dictionary<string, decimal> MemberToMemberDict = new Dictionary<string, decimal>();


            foreach(var expense in calculation.expenses)
            {
                decimal average = expense.Amount / expense.NumberOfMembersInvolved;

                for(byte i=0; i<expense.NumberOfMembersInvolved; i++)
                {
                    string Who_Whom = CreateStringForDictionary(expense, i);
                    
                    
                    
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

        public string CreateStringForDictionary(Expense expense, byte which)
        {
            //Tworzenie nazwy ktora bedzie dodana do slownika
            return expense.NamesOfMembersInvolved[which]+"_"+expense.Name;
        }

    //end of Class
    }
}
