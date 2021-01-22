using System;
using System.Collections.Generic;
using System.Text;
using WebTripShare.Models;
using System.Linq;
using Moq;

namespace TripShare
{
    public class MockExpenseRepository : IExpenseRepository
    {
        //private readonly IExpenseRepository exprepo;

        //public MockExpenseRepository(IExpenseRepository exprepo)
        //{
        //    this.exprepo = exprepo;
        //}
        
        public List<Expense> GetAllExpenses()
        {
            List<Expense> expenses = new List<Expense>();
            expenses.Add(ExpenseMaker.CreateExpense(1, "Adam", 12.60m, "Igor,Heniek"));
            expenses.Add(ExpenseMaker.CreateExpense(1, "Igor", 6.15m, "Adam,Heniek"));
            expenses.Add(ExpenseMaker.CreateExpense(1, "Heniek", 24.30m, "Adam,Igor"));
            return expenses;
        }

        public void AddNewExpense(Expense expense)
        {
            //exprepo.AddNewExpense(expense);
        }
    }
}
