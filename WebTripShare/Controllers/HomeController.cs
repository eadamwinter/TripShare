﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TripShare;
using WebTripShare.Models;

namespace WebTripShare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IResultMaker resultMaker;
        private readonly ICalculation calculation;

        public HomeController(ILogger<HomeController> logger, IResultMaker resultMaker, ICalculation calculation)
        {
            _logger = logger;
            this.resultMaker = resultMaker;
            this.calculation = calculation;
        }

        public IActionResult Index()
        {

            var dict = calculation.CalculateShare();

            var result = resultMaker.PrepareResult(dict);
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
