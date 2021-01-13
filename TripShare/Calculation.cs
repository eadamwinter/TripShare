using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TripShare
{
    public class Calculation
    {
        public IOptymizer optymizer { get; set; }
        public ICalculationMethod calculationMethod { get; set; }
        public TableInfo tableInfo { get; set; }
        public IEnumerable<Expense> expenses { get; set; }

        public Calculation(List<Expense> expenses, TableInfo tableInfo, ICalculationMethod calculationMethod, IOptymizer optymizer)
        {
            this.expenses = expenses;
            this.tableInfo = tableInfo;
            this.calculationMethod = calculationMethod;
            this.optymizer = optymizer;
        }

        public Dictionary<string, decimal> CalculateShare()
        {
            var dict = calculationMethod.CalculateMembersExpenses(this);
            var smallerdict = calculationMethod.OptimizeDict(dict);
            return optymizer.OptimizeDict(smallerdict);
        }

        
    }
}
