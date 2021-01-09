using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class MockExpenseRepository : IExpenseRepository
    {
        
        public List<Expense> GetAllExpenses()
        {
            List<Expense> expenses = new List<Expense>();
            expenses.Add(new Expense(1, "Adam", 15.40));
            expenses.Add(new Expense(1, "Igor", 12.20));
            return expenses;
        }
    }
}
