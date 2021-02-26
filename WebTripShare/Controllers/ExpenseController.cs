using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
                if(em.MembersInvolved.Count()==1 && em.MembersInvolved.Contains(em.Name))
                {
                    ModelState.AddModelError("MembersInvolved", $"Choose different member than {em.Name}");
                    ViewBag.TableNumber = em.TableNumber;
                    return View();
                }

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

        [Route("table")]
        public IActionResult Del(int id, int table)
        {
            expenseRepository.DeleteExpense(id);
            return RedirectToAction("Details", new { id = table });
        }

        public IActionResult Edit(int id)
        {
            Expense expense = expenseRepository.GetExpenseById(id);
            if(expense != null)
            {
                ViewBag.Expense = expense;
                return View();
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(ExpenseEdit expEdit)
        {
            if(ModelState.IsValid)
            {
                expenseRepository.EditExpense(expEdit);
                return RedirectToAction("Details", new { id = expEdit.TableNumber });
            }

            ViewBag.Expense = expenseRepository.GetExpenseById(expEdit.ExpenseId);
            return View(expEdit);
        }

        
        public IActionResult Details(int id)
        {
            List<Expense> expenses = expenseRepository.GetAllExpenses((byte)id);

            return View(expenses);
        }

    }
}
