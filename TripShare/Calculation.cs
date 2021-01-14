using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TripShare
{
    public class Calculation:ICalculation
    {
        public IOptymizer optymizer { get; set; }
        public ICalculationMethod calculationMethod { get; set; }
        public IExpenseRepository expenseRepository { get; set; }
        public ITableRepository tableRepository { get; set; }

        public Calculation(IExpenseRepository expenseRepository, ITableRepository tableRepository, ICalculationMethod calculationMethod, IOptymizer optymizer)
        {
            this.tableRepository = tableRepository;
            this.calculationMethod = calculationMethod;
            this.optymizer = optymizer;
            this.expenseRepository = expenseRepository;
        }

        public Dictionary<string, decimal> CalculateShare()
        {
            Dictionary<string, decimal> dict = calculationMethod.CalculateMembersExpenses(this);
            Dictionary<string, decimal> smallerdict = calculationMethod.OptimizeDict(dict);
            return optymizer.OptimizeDict(smallerdict);
        }

        
    }
}
