using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripShare;
using WebTripShare.Models;

namespace WebTripShare.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly AppDbContext appDbContext;
        //private readonly IExpenseRepository expenseRepository { get; set; }
        public ExpenseController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
            // tutaj wsadz ExpenseRepository jak bedzie gotowe
        }
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(ExpenseMaker em)
        {
            if(ModelState.IsValid)
            {
                Expense expense = ExpenseMaker.CreateExpense(em.TableNumber, em.Name, em.Amount, em.MembersInvolved, em.Comment);
                IExpenseRepository expenseRepository = new ExpenseRepository(appDbContext);
                expenseRepository.AddNewExpense(expense);
                return RedirectToAction("Success");
            }
            return View(em);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
