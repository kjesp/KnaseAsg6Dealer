﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KnaseAsg5Dealer.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KnaseAsg5Dealer.Controllers
{
    public class HomeController : Controller
    {
        private CarContext context { get; set; }

        public HomeController(CarContext ctx)
        {
            context = ctx;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
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
