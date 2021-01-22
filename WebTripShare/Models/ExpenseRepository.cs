using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripShare;

namespace WebTripShare.Models
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly AppDbContext appDbContext;
        public ExpenseRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public void AddNewExpense(Expense expense)
        {
            appDbContext.Expenses.Add(expense);
            appDbContext.SaveChanges();
        }

        public List<Expense> GetAllExpenses()
        {
            return appDbContext.Expenses.Where(e => e.TableNumber == 1).ToList();
        }
    }
}
