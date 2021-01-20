﻿using System;
using System.Collections.Generic;
using System.Text;
using WebTripShare.Models;
using System.Linq;

namespace TripShare
{
    public class MockExpenseRepository : IExpenseRepository
    {
        
        public List<Expense> GetAllExpenses()
        {
            ExpenseMaker expMaker = new ExpenseMaker();

            List<Expense> expenses = new List<Expense>();
            expenses.Add(expMaker.CreateExpense(1, "Adam", 12.60m, "Igor,Heniek"));
            expenses.Add(expMaker.CreateExpense(1, "Igor", 6.15m, "Adam,Heniek"));
            expenses.Add(expMaker.CreateExpense(1, "Heniek", 24.30m, "Adam,Igor"));
            return expenses;
        }
    }
}
