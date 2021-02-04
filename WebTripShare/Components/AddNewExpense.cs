using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTripShare.Components
{
    public class AddNewExpense:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
