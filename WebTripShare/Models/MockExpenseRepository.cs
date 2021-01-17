using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public class MockExpenseRepository : IExpenseRepository
    {
        
        public List<Expense> GetAllExpenses()
        {
            ExpenseMaker expMaker = new ExpenseMaker();

            List<Expense> expenses = new List<Expense>();
            expenses.Add(expMaker.CreateExpense(1, "Adam", 12.60m, new List<string>() { "Igor", "Heniek" }));
            expenses.Add(expMaker.CreateExpense(1, "Igor", 6.15m, new List<string>() { "Adam", "Heniek" }));
            expenses.Add(expMaker.CreateExpense(1, "Heniek", 24.30m, new List<string>() { "Adam", "Igor" }));
            return expenses;
        }
    }
}
