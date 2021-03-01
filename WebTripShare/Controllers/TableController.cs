using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using TripShare;
using WebTripShare.Models;

namespace WebTripShare.Controllers
{
    public class TableController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly ITableRepository _tableRepository;
        private readonly IResultMaker _resultMaker;
        private readonly ICalculation _calculation;

        protected ActualResults _result { get; set; }

        public TableController(AppDbContext appDbContext, ITableRepository tableRepository, IResultMaker resultMaker, ICalculation calculation, ActualResults actualResults)
        {
            _appDbContext = appDbContext;
            _tableRepository = tableRepository;
            _resultMaker = resultMaker;
            _calculation = calculation;
            _result = actualResults;
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewTableViewModel model)
        {

            if (ModelState.IsValid)
            {
                if (_appDbContext.Tables.Any(a => a.TableName == model.TableName))
                {
                    ModelState.AddModelError("TableName", "There is already group with this name in the database");
                    return View();
                }

                if (model.Names == null || model.Names.Count < 2 || model.Names.Count > 15)
                {
                    ModelState.AddModelError("Names", "There must be at least 2 members and no more than 15");
                    return View();
                }

                if (model.NumberOfMembers > model.Names.Count)
                {
                    ModelState.AddModelError("Names", "Names must be unique");
                    return View();
                }

                if (model.Names.Contains(null))
                {
                    ModelState.AddModelError("Names", "Names must be unique and have more than 1 letter");
                    return View();
                }

                foreach (var name in model.Names)
                {
                    name.Trim();
                    if (name.Length < 1 || name.Length > 20)
                    {
                        ModelState.AddModelError("Names", "The name is too short or too long");
                        return View();
                    }
                }
            }
            else
            {
                return View();
            }

            TableRepository tableRepository = new TableRepository(_appDbContext);
            tableRepository.AddNewTable(model);

            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            return View();
        }
        public IActionResult AllTables()
        {
            List<TableInfo> tables = _tableRepository.GetTables();
            return View(tables);
        }

        public IActionResult Delete(int id)
        {
            return View(id);
        }

        [HttpPost]
        public IActionResult Delete(IFormCollection collection)
        {

            var id = Int16.Parse(collection["tableid"]);
            if (id != -1)
            {
                _tableRepository.DeleteTable((byte)id);
            }


            return RedirectToAction("AllTables");
        }

        public IActionResult Info(byte id)
        {
            TableInfo info = _tableRepository.GetTableById(id);
            if (info == null) { return NotFound(); }

            List<string> result = null;

            if (_appDbContext.Expenses.Any(x => x.TableNumber == id))
            {
                var dict = _calculation.CalculateShare(id);
                result = _resultMaker.PrepareResult(dict);
            }

            _result.resultList = result;

            TableViewModel data = new TableViewModel(result, info);
            return View(data);
        }

        public IActionResult SpecificInfo(string name)
        {
            if(name=="all")
            {
                return Ok(_result.resultList);
            }
            
            List<string> personalExpenses = new List<string>();
            foreach (var line in _result.resultList)
            {
                if (line.Contains(name))
                {
                    personalExpenses.Add(line);
                }
            }
            return Ok(personalExpenses);
        }
    }
}
