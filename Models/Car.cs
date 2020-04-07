using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnaseAsg5Dealer.Models
{
    public class Car
    {

        private static int id;  // Used as Auto Increment ID

        public Car(string year, string make, string model, string price, string mileage, string color)
        {
            id++;  // Belongs to the Class, basically auto increment
            ID = id;
            //  MakeModel = makeModel;
            Make = make;
            Model = model;
            Year = int.Parse(year);
            Price = int.Parse(price);
            Mileage = int.Parse(mileage);
            Color = color;
        }

        public int ID { get; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
    }
}
