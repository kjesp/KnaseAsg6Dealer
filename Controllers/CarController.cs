using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnaseAsg5Dealer.Models;
using Microsoft.EntityFrameworkCore;

namespace KnaseAsg5Dealer.Controllers
{
    public class CarController : Controller
    {
       
        private CarContext context { get; set; }

        public CarController(CarContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchResults()
        {
            return View();
        }

        //[Route("/cars/list")]
        public IActionResult List()
        {            
            var cars = context.Cars.OrderBy(m => m.Id).ToList();
            return View(cars);
        }

        //[Route("/car/{id?}")]
        public IActionResult Detail(int? id)
        {
            var car = context.Cars.Where(m => m.Id == id).FirstOrDefault();            
            return View(car);
        }

        public IActionResult Search()
        {
            return View();
        }


        /***********************POST*******************************************************/

        //[Route("/car/list")]        
        [HttpPost]
        public IActionResult SearchForm(string sortType, string searchType, string searchField)
        {           
            List<Car> carsList = new List<Car>();

            carsList = searchProcess(searchType, searchField);            
            
            return View("~/Views/Car/SearchResults.cshtml", carsList);
        }

        //[Route("/cars/sort/{sortType}")]
        [HttpPost]
        public IActionResult sortList(string sortType)
        {
            List<Car> carsList = new List<Car>();

            carsList = sortProcess(sortType);

            return View("~/Views/Car/List.cshtml", carsList);
        }      
        
        /************************************************************/
        

        public List<Car> sortProcess(string sortBy)
        {
            List<Car> sortedList = new List<Car>();
            sortedList = context.Cars.ToList();
            ViewBag.SortType = sortBy;

            switch (sortBy)
            {
                case "yearAsc":                    
                    sortedList = sortedList.OrderBy(m => m.Year).ToList();                    
                    return sortedList;

                case "ID":
                    sortedList = sortedList.OrderBy(m => m.Id).ToList();
                    return sortedList;

                case "yearDesc":
                    sortedList = sortedList.OrderByDescending(m => m.Year).ToList();
                    return sortedList;

                case "priceAsc":
                    sortedList = sortedList.OrderBy(m => m.Price).ToList();
                    return sortedList;

                case "priceDesc":
                    sortedList = sortedList.OrderByDescending(m => m.Price).ToList();
                    return sortedList;

                case "mileageAsc":
                    sortedList = sortedList.OrderBy(o => o.Mileage).ToList();
                    return sortedList;

                case "mileageDesc":
                    sortedList = sortedList.OrderByDescending(o => o.Mileage).ToList();
                    return sortedList;

                case "color":
                    sortedList = sortedList.OrderBy(o => o.Color).ToList();
                    return sortedList;

                case "price":
                    sortedList = sortedList.OrderBy(o => o.Price).ToList();
                    return sortedList;

                case "make":
                    sortedList = sortedList.OrderBy(o => o.Make).ToList();
                    return sortedList;


                case "model":
                    sortedList = sortedList.OrderBy(o => o.Model).ToList();
                    return sortedList;
            }

            return sortedList;
        }

        public List<Car> searchProcess(string searchType, string searchField)
        {
            List<Car> searchList = new List<Car>();
            List<Car> tempList = new List<Car>();

            switch (searchType)
                {
                    case "color":
                        searchList = context.Cars.Where(m => m.Color == searchField).ToList();
                        break;

                    case "year":
                        int year;
                        if (int.TryParse(searchField, out year))
                        {
                            searchList = context.Cars.Where(m => m.Year == year).ToList();
                        }
                        break;

                     case "makeModel":
                        searchList = context.Cars.Where(m => m.Model == searchField).ToList();
                        tempList = context.Cars.Where(m => m.Make == searchField).ToList();

                            foreach (var item in tempList)
                                {
                                    searchList.Add(item);
                                }                    
                        break;
                } 

                return searchList;
        }

    }
}