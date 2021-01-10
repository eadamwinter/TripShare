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
            expenses.Add(new Expense(1, "Adam", 12.60m, new List<string>() { "Igor", "Heniek" }));
            expenses.Add(new Expense(1, "Igor", 6.15m, new List<string>() { "Adam", "Heniek" }));
            expenses.Add(new Expense(1, "Heniek", 24.30m, new List<string>() { "Adam", "Igor" }));
            return expenses;
        }
    }
}
