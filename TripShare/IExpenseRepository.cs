using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface IExpenseRepository
    {
        List<Expense> GetAllExpenses(byte tableNumber);
        void AddNewExpense(Expense expense);
        void DeleteExpense(int id);
        Expense GetExpenseById(int id);
        void EditExpense(int id, Expense expense);
    }
}
