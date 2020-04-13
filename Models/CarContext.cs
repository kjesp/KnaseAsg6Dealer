using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KnaseAsg5Dealer.Models
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options)
            : base(options)
        { }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(

                new Car { Id = 1, Year = 2013, Make = "Nissan", Model = "Sentra", Price = "8995", Mileage = "84574", Color = "Silver" },
                new Car { Id = 2, Year = 2014, Make = "Chevrolet", Model = "Spark LS", Price = "8995", Mileage = "35304", Color = "Blue" },
                new Car { Id = 3, Year = 2013, Make = "Ford", Model = "Escape 4WD SE", Price = "10900", Mileage = "70873", Color = "Blue" },
                new Car { Id = 4, Year = 2014, Make = "Kia", Model = "Soul", Price = "10900", Mileage = "54691", Color = "White" },
                new Car { Id = 5, Year = 2013, Make = "Hyundai", Model = "Tucson AWD", Price = "11900", Mileage = "72115", Color = "Green" },
                new Car { Id = 6, Year = 2018, Make = "Nissan", Model = "Versa", Price = "11900", Mileage = "44013", Color = "Red" },
                new Car { Id = 7, Year = 2015, Make = "Chevrolet", Model = "Equinox AWD LS", Price = "11900", Mileage = "94401", Color = "Silver" },
                new Car { Id = 8, Year = 2015, Make = "Kia", Model = "Sedona LX", Price = "11900", Mileage = "72751", Color = "Red" },
                new Car { Id = 9, Year = 2016, Make = "Hyundai", Model = "Veloster", Price = "11900", Mileage = "49369", Color = "White" },
                new Car { Id = 10, Year = 2011, Make = "Cadillac", Model = "DTS Luxury", Price = "12900", Mileage = "76443", Color = "White" },
                new Car { Id = 11, Year = 2014, Make = "Chevrolet", Model = "Malibu LS w/ PROTECTION PACKAGE", Price = "12900", Mileage = "28232", Color = "Blue" },
                new Car { Id = 12, Year = 2018, Make = "Nissan", Model = "Sentra", Price = "13900", Mileage = "37665", Color = "White" },
                new Car { Id = 13, Year = 2014, Make = "Subaru", Model = "Crosstrek 2.0i Premium", Price = "13900", Mileage = "65360", Color = "Tan" },
                new Car { Id = 14, Year = 2017, Make = "Hyundai", Model = "Elantra Sedan", Price = "13900", Mileage = "29059", Color = "Blue" },
                new Car { Id = 15, Year = 2017, Make = "Hyundai", Model = "Elantra Sedan w/ CARGO PACKAGE", Price = "14900", Mileage = "25474", Color = "White" },
                new Car { Id = 16, Year = 2016, Make = "Dodge", Model = "Grand Caravan SXT", Price = "14900", Mileage = "70812", Color = "Black" },
                new Car { Id = 17, Year = 2016, Make = "Jeep", Model = "Cherokee 4WD Sport", Price = "14900", Mileage = "73122", Color = "Silver" },
                new Car { Id = 18, Year = 2017, Make = "Chevrolet", Model = "Cruze LT Sedan", Price = "14900", Mileage = "20560", Color = "Red" },
                new Car { Id = 19, Year = 2017, Make = "Hyundai", Model = "Elantra Sedan", Price = "14900", Mileage = "24851", Color = "Red" },
                new Car { Id = 20, Year = 2014, Make = "Cadillac", Model = "CTS Sedan w/ SEATING PACKAGE", Price = "14900", Mileage = "69141", Color = "Black" },
                new Car { Id = 21, Year = 2016, Make = "Dodge", Model = "Grand Caravan SXT", Price = "15495", Mileage = "70133", Color = "White" },
                new Car { Id = 22, Year = 2017, Make = "Nissan", Model = "Altima", Price = "15900", Mileage = "14808", Color = "Gray" },
                new Car { Id = 23, Year = 2017, Make = "Chevrolet", Model = "Trax AWD LS", Price = "15900", Mileage = "21027", Color = "Silver" },
                new Car { Id = 24, Year = 2016, Make = "Nissan", Model = "Rogue AWD w/ SV PREMIUM PACKAGE", Price = "15900", Mileage = "53087", Color = "Red" },
                new Car { Id = 25, Year = 2019, Make = "Chevrolet", Model = "Sonic LT Sedan w/ RS PACKAGE", Price = "15900", Mileage = "2928", Color = "White" },
                new Car { Id = 26, Year = 2017, Make = "Dodge", Model = "Grand Caravan SXT", Price = "15900", Mileage = "68671", Color = "Gray" },
                new Car { Id = 27, Year = 2016, Make = "Buick", Model = "Encore FWD Convenience", Price = "15900", Mileage = "17734", Color = "Red" },
                new Car { Id = 28, Year = 2016, Make = "Buick", Model = "Encore AWD", Price = "15900", Mileage = "40059", Color = "Gray" },
                new Car { Id = 29, Year = 2008, Make = "Jeep", Model = "Wrangler 4WD Sahara", Price = "15900", Mileage = "71164", Color = "Silver" },
                new Car { Id = 30, Year = 2016, Make = "Chevrolet", Model = "Malibu LT", Price = "15900", Mileage = "42687", Color = "Silver" },
                new Car { Id = 31, Year = 2017, Make = "Hyundai", Model = "Sonata SE", Price = "15900", Mileage = "30066", Color = "Red" },
                new Car { Id = 32, Year = 2017, Make = "Nissan", Model = "Altima", Price = "15900", Mileage = "52533", Color = "Gray" },
                new Car { Id = 33, Year = 2018, Make = "Ford", Model = "Focus SE Hatchback", Price = "15900", Mileage = "8040", Color = "Yellow" },
                new Car { Id = 34, Year = 2015, Make = "Honda", Model = "Civic Si Coupe", Price = "15900", Mileage = "76904", Color = "Blue" },
                new Car { Id = 35, Year = 2013, Make = "Ford", Model = "Explorer 4WD", Price = "15900", Mileage = "61089", Color = "Black" },
                new Car { Id = 36, Year = 2017, Make = "Nissan", Model = "Altima", Price = "16495", Mileage = "30478", Color = "White" },
                new Car { Id = 37, Year = 2013, Make = "Cadillac", Model = "XTS Luxury", Price = "16900", Mileage = "64693", Color = "Silver" },
                new Car { Id = 38, Year = 2017, Make = "Ford", Model = "Fusion SE", Price = "16900", Mileage = "29494", Color = "White" },
                new Car { Id = 39, Year = 2018, Make = "Nissan", Model = "Altima", Price = "16900", Mileage = "36416", Color = "Red" },
                new Car { Id = 40, Year = 2019, Make = "Nissan", Model = "Sentra", Price = "16900", Mileage = "8749", Color = "Blue" },
                new Car { Id = 41, Year = 2016, Make = "Dodge", Model = "Grand Caravan SE", Price = "16900", Mileage = "38075", Color = "Red" },
                new Car { Id = 42, Year = 2017, Make = "Chevrolet", Model = "Equinox AWD LS", Price = "16900", Mileage = "35675", Color = "Black" },
                new Car { Id = 43, Year = 2016, Make = "GMC", Model = "Terrain AWD SLE w/ SLE-1", Price = "16900", Mileage = "34019", Color = "Red" },
                new Car { Id = 44, Year = 2016, Make = "Hyundai", Model = "Santa Fe AWD Sport w/ OPTION GROUP 03", Price = "17495", Mileage = "62375", Color = "Blue" },
                new Car { Id = 45, Year = 2017, Make = "Chevrolet", Model = "Equinox AWD LT w/ CONVENIENCE PACKAGE", Price = "17900", Mileage = "37334", Color = "Silver" },
                new Car { Id = 46, Year = 2016, Make = "Buick", Model = "Encore AWD Premium", Price = "17900", Mileage = "49013", Color = "White" },
                new Car { Id = 47, Year = 2015, Make = "Honda", Model = "CR-V AWD EX-L", Price = "17900", Mileage = "73227", Color = "Silver" },
                new Car { Id = 48, Year = 2016, Make = "MAZDA", Model = "CX-3 Grand Touring", Price = "17900", Mileage = "45925", Color = "Blue" },
                new Car { Id = 49, Year = 2016, Make = "Hyundai", Model = "Tucson AWD", Price = "17900", Mileage = "32063", Color = "Orange" },
                new Car { Id = 50, Year = 2015, Make = "Toyota", Model = "RAV4 AWD Limited", Price = "17900", Mileage = "69173", Color = "Red" },
                new Car { Id = 51, Year = 2010, Make = "Honda", Model = "Civic", Price = "9000", Mileage = "65000", Color = "Gray" },
                new Car { Id = 52, Year = 1999, Make = "Geo", Model = "Prism", Price = "100", Mileage = "300000", Color = "Red" },
                new Car { Id = 53, Year = 2017, Make = "Ford", Model = "Fiesta", Price = "12000", Mileage = "30000", Color = "Blue" },
                new Car { Id = 54, Year = 2015, Make = "SpaceX", Model = "Civilian Space Commuter", Price = "150000", Mileage = "760300", Color = "Silver" }

                );
            ;
        }
    }
}


