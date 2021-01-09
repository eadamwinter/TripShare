using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class Calculation
    {
        public TableInfo tableInfo { get; set; }
        public IEnumerable<Expense> expenses { get; set; }
        public Calculation(List<Expense> expenses, TableInfo tableInfo)
        {
            this.expenses = expenses;
            this.tableInfo = tableInfo;
        }

        public double CalculateEqualExpense()
        {
            double result = 0;
            foreach(var expense in expenses)
            {
                result += expense.wydatek;

            }
            result /= tableInfo.NumberOfMembers;
            return result;
        }
    }
}
