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

        public List<Expense> GetAllExpenses(byte tableNumber)
        {
            if(appDbContext.Expenses.Any(a=>a.TableNumber==tableNumber))
            {
                return appDbContext.Expenses.Where(e => e.TableNumber == tableNumber).ToList();
            }
            return null;
        }

        public void DeleteExpense(int id)
        {
            var expense = appDbContext.Expenses.First(x => x.ExpenseId == id);
            if(expense!=null)
            {
                appDbContext.Expenses.Remove(expense);
                appDbContext.SaveChanges();
            }
            
        }

        public Expense GetExpenseById(int id)
        {
            return appDbContext.Expenses.First(e => e.ExpenseId == id);
        }

        public void EditExpense(int id, Expense exp)
        {
            Expense expense = GetExpenseById(id);
            if(expense!=null)
            {
                expense.Name = exp.Name;
                expense.NumberOfMembersInvolved = exp.NumberOfMembersInvolved;
                expense.NamesOfMembersInvolved = exp.NamesOfMembersInvolved;
                expense.Amount = exp.Amount;
                expense.Comment = exp.Comment;

                appDbContext.SaveChanges();
            }
        }

    }
}
