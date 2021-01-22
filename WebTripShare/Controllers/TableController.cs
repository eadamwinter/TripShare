using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripShare;
using WebTripShare.Models;
using WebTripShare.Models.AddingData;

namespace WebTripShare.Controllers
{
    public class TableController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly ITableRepository _tableRepository;

        Koles koles { get; set; }

        public TableController(AppDbContext appDbContext, ITableRepository tableRepository)
        {
            _appDbContext = appDbContext;
            _tableRepository = tableRepository;
        }
        public IActionResult Add()
        {
            //koles = new Koles();
            return View();
        }

        [HttpPost]
        public IActionResult Add(string name, bool dupa)
        {

            if(name=="k")
            {
                if(dupa==true) { return RedirectToAction("Index", "Home"); }

                return RedirectToAction("Success");
            }
            return View();
        }

        public IActionResult Success()
        {
            //DontUse dontUse = new DontUse(_appDbContext);
            //dontUse.AddTableData();
            return View();
        }
        public IActionResult AllTables()
        {
            List<TableInfo> tables =_tableRepository.GetTables();
            return View(tables);
        }

        public IActionResult Info(byte id)
        {
            TableInfo info = _tableRepository.GetTableById(id);
            return View(info);
        }
    }
}
