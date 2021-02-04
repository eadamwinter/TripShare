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
        public IActionResult Add(int id)
        {
            if(id==0) { return RedirectToAction("Add0"); }
            ViewBag.TableNumber = (byte)id;
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(ExpenseMapper em)
        {
            if(ModelState.IsValid)
            {
                //Expense expense = ExpenseMaker.CreateExpense(em.TableNumber, em.Name, em.Amount, em.MembersInvolved, em.Comment);
                //IExpenseRepository expenseRepository = new ExpenseRepository(appDbContext);
                //expenseRepository.AddNewExpense(expense);
                return RedirectToAction("Success");
            }
            return View(em);
        }
        public IActionResult Add0()
        {
            return View();
        }

        public IActionResult Success(string membersinv)
        {
            return View(membersinv);
        }

        public IActionResult NewExpense(byte TableNumber, [FromServices] ITableRepository tableRepository)
        {
            if (TableNumber == 0)
            {
                TableNumber = 1;
            }
            var data = tableRepository.GetTableById(TableNumber);
            return View(data);
        }

        public IActionResult New()
        {
            return View();
        }
    }
}
