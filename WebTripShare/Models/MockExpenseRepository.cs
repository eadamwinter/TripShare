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
        
        public List<Expense> GetAllExpenses(byte tableNumber)
        {
            List<Expense> expenses = new List<Expense>();
            expenses.Add(ExpenseMaker.CreateExpense(1, "Adam", 12.60m, new List<string>() {"Igor","Heniek" }));
            expenses.Add(ExpenseMaker.CreateExpense(1, "Igor", 6.15m, new List<string>() { "Adam", "Heniek" }));
            expenses.Add(ExpenseMaker.CreateExpense(1, "Heniek", 24.30m, new List<string>() { "Adam", "Igor" }));
            return expenses;
        }

        public void AddNewExpense(Expense expense)
        {
            //exprepo.AddNewExpense(expense);
        }

        public void DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }

        public Expense GetExpenseById(int id)
        {
            throw new NotImplementedException();
        }

        public void EditExpense(int id, Expense expense)
        {
            throw new NotImplementedException();
        }
    }
}
