using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnaseAsg5Dealer.Models;
using Microsoft.AspNetCore.Mvc;

namespace KnaseAsg5Dealer.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarController : Controller
    {
        [Route("[area]/[controller]s/{id?}")]

        public IActionResult Index()
        {
            return View();
        }


        [Route("/Admin/add")]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/admin/SubmitAdd")]
        [HttpPost]
        public IActionResult SubmitAdd(string year, string make, string model, string price, string mileage, string color)
        {
            List<Car> cars = DB.add(year, make, model, price, mileage, color);
            return View("~/Views/Car/List.cshtml", cars);
        }
    }
}