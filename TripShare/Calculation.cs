using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class Calculation
    {
        public byte NumberOfMembers { get; set; }
        public List<Expense> expenses { get; set; }
        public Calculation(List<Expense> expenses, byte numberOfMembers)
        {
            this.expenses = expenses;
            NumberOfMembers = numberOfMembers;
        }

        public double CalculateEqualExpense()
        {
            double result = 0;
            foreach(var expense in expenses)
            {
                result += expense.wydatek;

            }
            result /= NumberOfMembers;
            return result;
        }
    }
}
