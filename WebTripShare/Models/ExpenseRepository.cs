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
            return appDbContext.Expenses.FirstOrDefault(e => e.ExpenseId == id);
        }

        public void EditExpense(ExpenseEdit exp)
        {
            Expense expense = GetExpenseById(exp.ExpenseId);
            Expense newExp = ExpenseMaker.CreateExpense(exp.TableNumber, exp.Name, exp.Amount, exp.MembersInvolved, exp.Comment);
            if(expense!=null)
            {
                expense.Name = newExp.Name;
                expense.NumberOfMembersInvolved = newExp.NumberOfMembersInvolved;
                expense.NamesOfMembersInvolved = newExp.NamesOfMembersInvolved;
                expense.Amount = newExp.Amount;
                expense.Comment = newExp.Comment;

                appDbContext.SaveChanges();
            }
        }

    }
}
