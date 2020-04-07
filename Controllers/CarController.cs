using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnaseAsg5Dealer.Models;

namespace KnaseAsg5Dealer.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/cars")]
        public IActionResult List()
        {
            List<Car> cars = DB.noSort();
            return View(cars);
        }

        [Route("/car/{id?}")]
        public IActionResult Detail(int? id)
        {
            Car car = DB.GetCarByID(id ?? 1);
            return View(car);
        }


        public IActionResult Search()
        {
            //    List<Car> cars = db.search(searchType, searchField);
            return View();
        }

        [Route("/list")]        
        [HttpPost]
        public IActionResult List(String sortType, String searchType, String searchField)
        {
            if(searchType == "" || searchType == null)
            {
                List<Car> cars = DB.sort(sortType);
                return View(cars);
            }
            else
            {
                List<Car> cars = DB.search(searchType, searchField);
                return View(cars);
            }
                      
        }
        

        [Route("/cars/sort/year/order-desc")]        
        public IActionResult ListDesc()
        {
            DB.isAscYear = false;
            List<Car> cars = DB.sort("year");
            return View("~/Views/Car/List.cshtml", cars);
        }


        [Route("/cars/{searchField}")]
        public IActionResult SearchTest(String? searchField)
        {

            List<Car> cars = DB.searchAcrossCategories(searchField ?? "geo");
            return View("~/Views/Car/List.cshtml", cars);
        }

        [Route("/cars/sort/year/order-asc")]
        public IActionResult ListAsc()
        {
            DB.isAscYear = true;
            List<Car> cars = DB.sort("year");
            return View("~/Views/Car/List.cshtml", cars);
        }



        [Route("/cars/sort/{sortType}")]
        public IActionResult ListSort(string sortType)
        {
            DB.isAscYear = true;
            List<Car> cars = DB.sort(sortType);
            return View("~/Views/Car/List.cshtml", cars);
        
        }



    }
}