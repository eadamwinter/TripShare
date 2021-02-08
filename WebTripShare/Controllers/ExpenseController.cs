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
        public IExpenseRepository expenseRepository { get; set; }
        public ExpenseController(AppDbContext appDbContext, IExpenseRepository expenseRepository)
        {
            this.appDbContext = appDbContext;
            this.expenseRepository = expenseRepository;
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
                Expense expense = ExpenseMaker.CreateExpense(em.TableNumber, em.Name, em.Amount, em.MembersInvolved, em.Comment);
                expenseRepository.AddNewExpense(expense);
                return RedirectToAction("Success", new { id = em.TableNumber });
            }
            ViewBag.TableNumber = em.TableNumber;
            return View(em);
        }
        public IActionResult Add0()
        {
            return View();
        }

        public IActionResult Success(int id)
        {
            return View(id);
        }

        public IActionResult Details(int id)
        {
            List<Expense> expenses = expenseRepository.GetAllExpenses((byte)id);
            if (expenses == null) { return NotFound(); }

            return View(expenses);
        }

    }
}
