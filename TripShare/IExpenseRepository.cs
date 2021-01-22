﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TripShare
{
    public interface IExpenseRepository
    {
        List<Expense> GetAllExpenses();
        void AddNewExpense(Expense expense);
    }
}
