using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnaseAsg5Dealer.Models
{
    public static class DB
    {
        private static List<Car> cars = new List<Car>();

        public static bool isAscYear { get; set; }

        //static DB()
        //{
        //    loadCars();
        //}

        public enum sortOrder { MakeModel, Year, Price, Mileage, Color };

        //public static Car GetCarByID(int id)
        //{
        //    List<Car> carList = new List<Car>();
        //    carList = cars;
        //    foreach (Car car in cars)
        //    {
        //        if (car.ID == id)
        //        {
        //            return car;
        //        }
        //    }
        //    return null;
        //}

        //public static List<Car> add(string year, string make, string model, string price, string mileage, string color)
        //{
        //    cars.Add(new Car(year, make, model, price, mileage, color));
        //    // cars.Add(new Car("2000", "TestMake", "TestModel", "1100", "1000", "testColor"));

        //    return cars;
        //}


        //public static List<Car> sort(String sortBy)
        //{
        //List<Car> sortedList = new List<Car>();
        //sortedList = cars;
        //String sort = sortBy;

        //switch (sortBy)
        //{
        //    case "year":
        //        if (isAscYear)
        //        {
        //            sortedList = cars.OrderBy(o => o.Year).ToList();
        //        }
        //        else
        //        {
        //            sortedList = cars.OrderByDescending(o => o.Year).ToList();
        //        }

        //        // sortedList = cars.OrderBy(o => o.Year).ToList();
        //        isAscYear = !isAscYear;
        //        return sortedList;

        //    //case "yearDesc":
        //    //    sortedList = cars.OrderByDescending(o => o.Year).ToList();
        //    //    isAscYear = !isAscYear;
        //    //    return sortedList;

        //    case "ID":
        //        sortedList = cars.OrderBy(o => o.ID).ToList();
        //        return sortedList;

        //    //case "makeModel":
        //    //    sortedList = cars.OrderBy(o => o.MakeModel).ToList();
        //    //    return sortedList;

        //    case "priceAsc":
        //        sortedList = cars.OrderBy(o => o.Price).ToList();
        //        return sortedList;

        //    case "priceDesc":
        //        sortedList = cars.OrderByDescending(o => o.Price).ToList();
        //        return sortedList;

        //    case "mileageAsc":
        //        sortedList = cars.OrderBy(o => o.Mileage).ToList();
        //        return sortedList;

        //    case "mileageDesc":
        //        sortedList = cars.OrderByDescending(o => o.Mileage).ToList();
        //        return sortedList;

        //    case "color":
        //        sortedList = cars.OrderBy(o => o.Color).ToList();
        //        return sortedList;

        //    case "price":
        //        sortedList = cars.OrderBy(o => o.Price).ToList();
        //        return sortedList;

        //    case "make":



        //        //go through cars list and get the substrings before space
        //        sortedList = cars.OrderBy(o => o.Make).ToList();
        //        return sortedList;


        //    case "model":
        //        //go through cars list and get the substrings after space. 
        //        sortedList = cars.OrderBy(o => o.Model).ToList();
        //        return sortedList;



        //}

        //    return sortedList;
        //}

        //public static List<Car> search(String searchType, String searchField)
        //{
        //    List<Car> searchResultsList = new List<Car>();
        //    String type = searchType;
        //    String searchValue = searchField;

        //    switch (searchType)
        //    {
        //        case "color":
        //            foreach (Car car in cars)
        //            {
        //                if (car.Color.StartsWith(searchField, StringComparison.InvariantCultureIgnoreCase))
        //                {
        //                    searchResultsList.Add(car);
        //                }

        //            }

        //            return searchResultsList;

        //        case "year":

        //            int year;
        //            if (int.TryParse(searchField, out year))
        //            {

        //                foreach (Car car in cars)
        //                {
        //                    if (car.Year == year)
        //                    {
        //                        searchResultsList.Add(car);
        //                    }

        //                }

        //                return searchResultsList;
        //            }
        //            else
        //            {
        //                return searchResultsList;
        //            }



        //        case "model":
        //            foreach (Car car in cars)
        //            {
        //                if (car.Model.StartsWith(searchField, StringComparison.InvariantCultureIgnoreCase))
        //                {
        //                    searchResultsList.Add(car);
        //                }

        //            }

        //            return searchResultsList;

        //        case "make":
        //            foreach (Car car in cars)
        //            {
        //                if (car.Make.StartsWith(searchField, StringComparison.InvariantCultureIgnoreCase))
        //                {
        //                    searchResultsList.Add(car);
        //                }

        //            }

        //            return searchResultsList;
        //    }

        //    return searchResultsList;
        //}

        //public static List<Car> searchAcrossCategories(String searchField)
        //{
        //    List<Car> searchResultsList = new List<Car>();
        //    String searchValue = searchField;

        //    foreach (Car car in cars)
        //    {
        //        if (car.Color.StartsWith(searchField, StringComparison.InvariantCultureIgnoreCase))
        //        {
        //            searchResultsList.Add(car);
        //        }

        //    }


        //    int year;
        //    if (int.TryParse(searchField, out year))
        //    {

        //        foreach (Car car in cars)
        //        {
        //            if (car.Year == year)
        //            {
        //                searchResultsList.Add(car);
        //            }

        //        }
        //    }

        //    foreach (Car car in cars)
        //    {
        //        if (car.Model.StartsWith(searchField, StringComparison.InvariantCultureIgnoreCase))
        //        {
        //            searchResultsList.Add(car);
        //        }

        //    }

        //    foreach (Car car in cars)
        //    {
        //        if (car.Make.StartsWith(searchField, StringComparison.InvariantCultureIgnoreCase))
        //        {
        //            searchResultsList.Add(car);
        //        }

        //    }


        //    return searchResultsList;
        //}































        //    public static List<Car> noSort()
        //    {
        //        List<Car> listNotSorted = new List<Car>();
        //        listNotSorted = cars;
        //        return listNotSorted;
        //    }


        //    public static void loadCars()
        //    {
        //        cars.Add(new Car("2013", "Nissan", "Sentra", "8995", "84574", "Silver"));
        //        cars.Add(new Car("2014", "Chevrolet", "Spark LS", "8995", "35304", "Blue"));
        //        cars.Add(new Car("2013", "Ford", "Escape 4WD SE", "10900", "70873", "Blue"));
        //        cars.Add(new Car("2014", "Kia", "Soul", "10900", "54691", "White"));
        //        cars.Add(new Car("2013", "Hyundai", "Tucson AWD", "11900", "72115", "Green"));
        //        cars.Add(new Car("2018", "Nissan", "Versa", "11900", "44013", "Red"));
        //        cars.Add(new Car("2015", "Chevrolet", "Equinox AWD LS", "11900", "94401", "Silver"));
        //        cars.Add(new Car("2015", "Kia", "Sedona LX", "11900", "72751", "Red"));
        //        cars.Add(new Car("2016", "Hyundai", "Veloster", "11900", "49369", "White"));
        //        cars.Add(new Car("2011", "Cadillac", "DTS Luxury", "12900", "76443", "White"));
        //        cars.Add(new Car("2014", "Chevrolet", "Malibu LS w/ PROTECTION PACKAGE", "12900", "28232", "Blue"));
        //        cars.Add(new Car("2018", "Nissan", "Sentra", "13900", "37665", "White"));
        //        cars.Add(new Car("2014", "Subaru", "Crosstrek 2.0i Premium", "13900", "65360", "Tan"));
        //        cars.Add(new Car("2017", "Hyundai", "Elantra Sedan", "13900", "29059", "Blue"));
        //        cars.Add(new Car("2017", "Hyundai", "Elantra Sedan w/ CARGO PACKAGE", "14900", "25474", "White"));
        //        cars.Add(new Car("2016", "Dodge", "Grand Caravan SXT", "14900", "70812", "Black"));
        //        cars.Add(new Car("2016", "Jeep", "Cherokee 4WD Sport", "14900", "73122", "Silver"));
        //        cars.Add(new Car("2017", "Chevrolet", "Cruze LT Sedan", "14900", "20560", "Red"));
        //        cars.Add(new Car("2017", "Hyundai", "Elantra Sedan", "14900", "24851", "Red"));
        //        cars.Add(new Car("2014", "Cadillac", "CTS Sedan w/ SEATING PACKAGE", "14900", "69141", "Black"));
        //        cars.Add(new Car("2016", "Dodge", "Grand Caravan SXT", "15495", "70133", "White"));
        //        cars.Add(new Car("2017", "Nissan", "Altima", "15900", "14808", "Gray"));
        //        cars.Add(new Car("2017", "Chevrolet", "Trax AWD LS", "15900", "21027", "Silver"));
        //        cars.Add(new Car("2016", "Nissan", "Rogue AWD w/ SV PREMIUM PACKAGE", "15900", "53087", "Red"));
        //        cars.Add(new Car("2019", "Chevrolet", "Sonic LT Sedan w/ RS PACKAGE", "15900", "2928", "White"));
        //        cars.Add(new Car("2017", "Dodge", "Grand Caravan SXT", "15900", "68671", "Gray"));
        //        cars.Add(new Car("2016", "Buick", "Encore FWD Convenience", "15900", "17734", "Red"));
        //        cars.Add(new Car("2016", "Buick", "Encore AWD", "15900", "40059", "Gray"));
        //        cars.Add(new Car("2008", "Jeep", "Wrangler 4WD Sahara", "15900", "71164", "Silver"));
        //        cars.Add(new Car("2016", "Chevrolet", "Malibu LT", "15900", "42687", "Silver"));
        //        cars.Add(new Car("2017", "Hyundai", "Sonata SE", "15900", "30066", "Red"));
        //        cars.Add(new Car("2017", "Nissan", "Altima", "15900", "52533", "Gray"));
        //        cars.Add(new Car("2018", "Ford", "Focus SE Hatchback", "15900", "8040", "Yellow"));
        //        cars.Add(new Car("2015", "Honda", "Civic Si Coupe", "15900", "76904", "Blue"));
        //        cars.Add(new Car("2013", "Ford", "Explorer 4WD", "15900", "61089", "Black"));
        //        cars.Add(new Car("2017", "Nissan", "Altima", "16495", "30478", "White"));
        //        cars.Add(new Car("2013", "Cadillac", "XTS Luxury", "16900", "64693", "Silver"));
        //        cars.Add(new Car("2017", "Ford", "Fusion SE", "16900", "29494", "White"));
        //        cars.Add(new Car("2018", "Nissan", "Altima", "16900", "36416", "Red"));
        //        cars.Add(new Car("2019", "Nissan", "Sentra", "16900", "8749", "Blue"));
        //        cars.Add(new Car("2016", "Dodge", "Grand Caravan SE", "16900", "38075", "Red"));
        //        cars.Add(new Car("2017", "Chevrolet", "Equinox AWD LS", "16900", "35675", "Black"));
        //        cars.Add(new Car("2016", "GMC", "Terrain AWD SLE w/ SLE-1", "16900", "34019", "Red"));
        //        cars.Add(new Car("2016", "Hyundai", "Santa Fe AWD Sport w/ OPTION GROUP 03", "17495", "62375", "Blue"));
        //        cars.Add(new Car("2017", "Chevrolet", "Equinox AWD LT w/ CONVENIENCE PACKAGE", "17900", "37334", "Silver"));
        //        cars.Add(new Car("2016", "Buick", "Encore AWD Premium", "17900", "49013", "White"));
        //        cars.Add(new Car("2015", "Honda", "CR-V AWD EX-L", "17900", "73227", "Silver"));
        //        cars.Add(new Car("2016", "MAZDA", "CX-3 Grand Touring", "17900", "45925", "Blue"));
        //        cars.Add(new Car("2016", "Hyundai", "Tucson AWD", "17900", "32063", "Orange"));
        //        cars.Add(new Car("2015", "Toyota", "RAV4 AWD Limited", "17900", "69173", "Red"));
        //        cars.Add(new Car("2010", "Honda", "Civic", "9000", "65000", "Gray"));
        //        cars.Add(new Car("1999", "Geo", "Prism", "100", "300000", "Red"));
        //        cars.Add(new Car("2017", "Ford", "Fiesta", "12000", "30000", "Blue"));
        //        cars.Add(new Car("2015", "SpaceX", "Civilian Space Commuter", "150000", "760300", "Silver"));
        //    }
    }
}
