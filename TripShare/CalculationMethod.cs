using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class CalculationMethod : ICalculationMethod
    {
        public Dictionary<string, double> CalculateMembersExpenses(Calculation calculation)
        {
            Dictionary<string, double> MemberExpense = new Dictionary<string, double>();
            foreach(var name in calculation.tableInfo.NamesOfMemebers)
            {
                MemberExpense.Add(name, 0);
            }
            foreach(var expense in calculation.expenses)
            {
                MemberExpense[expense.imie] += expense.wydatek;
            }
            return MemberExpense;
        }
    }
}
