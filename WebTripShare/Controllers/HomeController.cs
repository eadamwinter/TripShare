using System;
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
        //private readonly Dictionary<String, decimal> dict;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IOptymizer optymizer = new Optimizer();
            var simpledict1 = new Dictionary<string, decimal>() { { "Adam_Tomek", 1.0m}, { "Igor_Tomek", 2.0m},
                {"Heniek_Tomek", 1.0m }, {"Igor_Heniek", 1.0m} };
            Dictionary<string, decimal> dict = optymizer.OptimizeDict(simpledict1);

            return View(dict);
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
