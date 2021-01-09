using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TripShare
{
    public class Calculation
    {
        public ICalculationMethod calculationMethod { get; set; }
        public TableInfo tableInfo { get; set; }
        public IEnumerable<Expense> expenses { get; set; }

        public Calculation(List<Expense> expenses, TableInfo tableInfo, ICalculationMethod calculationMethod)
        {
            this.expenses = expenses;
            this.tableInfo = tableInfo;
            this.calculationMethod = calculationMethod;
        }

        public double CalculateEqualExpense()
        {
            return (from expense in expenses select expense.wydatek).Sum()/tableInfo.NumberOfMembers;
        }

        public Dictionary<string, double> CreateMemberExpenseDictionary()
        {
            return calculationMethod.CalculateMembersExpenses(this);
        }

        public string CalculatePrymitiveDebts()
        {
            var dict = this.CreateMemberExpenseDictionary();
            var average = this.CalculateEqualExpense();
            string wynik = "";
            foreach(var person in dict.Keys)
            {
                if(dict[person]>average)
                {
                    wynik += $"{person} dał więcej niż powinien";
                }
                else if(dict[person]==average) 
                {
                    wynik += $"{person} dał tyle ile trzeba";
                }
                else
                {
                    wynik += $"{person} dał za mało";
                }
            }
            return wynik;
        }
    }
}
