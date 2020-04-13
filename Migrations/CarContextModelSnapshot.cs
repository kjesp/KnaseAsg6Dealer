﻿// <auto-generated />
using System;
using KnaseAsg5Dealer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KnaseAsg5Dealer.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KnaseAsg5Dealer.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Make")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mileage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Silver",
                            Make = "Nissan",
                            Mileage = "84574",
                            Model = "Sentra",
                            Price = "8995",
                            Year = 2013
                        },
                        new
                        {
                            Id = 2,
                            Color = "Blue",
                            Make = "Chevrolet",
                            Mileage = "35304",
                            Model = "Spark LS",
                            Price = "8995",
                            Year = 2014
                        },
                        new
                        {
                            Id = 3,
                            Color = "Blue",
                            Make = "Ford",
                            Mileage = "70873",
                            Model = "Escape 4WD SE",
                            Price = "10900",
                            Year = 2013
                        },
                        new
                        {
                            Id = 4,
                            Color = "White",
                            Make = "Kia",
                            Mileage = "54691",
                            Model = "Soul",
                            Price = "10900",
                            Year = 2014
                        },
                        new
                        {
                            Id = 5,
                            Color = "Green",
                            Make = "Hyundai",
                            Mileage = "72115",
                            Model = "Tucson AWD",
                            Price = "11900",
                            Year = 2013
                        },
                        new
                        {
                            Id = 6,
                            Color = "Red",
                            Make = "Nissan",
                            Mileage = "44013",
                            Model = "Versa",
                            Price = "11900",
                            Year = 2018
                        },
                        new
                        {
                            Id = 7,
                            Color = "Silver",
                            Make = "Chevrolet",
                            Mileage = "94401",
                            Model = "Equinox AWD LS",
                            Price = "11900",
                            Year = 2015
                        },
                        new
                        {
                            Id = 8,
                            Color = "Red",
                            Make = "Kia",
                            Mileage = "72751",
                            Model = "Sedona LX",
                            Price = "11900",
                            Year = 2015
                        },
                        new
                        {
                            Id = 9,
                            Color = "White",
                            Make = "Hyundai",
                            Mileage = "49369",
                            Model = "Veloster",
                            Price = "11900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 10,
                            Color = "White",
                            Make = "Cadillac",
                            Mileage = "76443",
                            Model = "DTS Luxury",
                            Price = "12900",
                            Year = 2011
                        },
                        new
                        {
                            Id = 11,
                            Color = "Blue",
                            Make = "Chevrolet",
                            Mileage = "28232",
                            Model = "Malibu LS w/ PROTECTION PACKAGE",
                            Price = "12900",
                            Year = 2014
                        },
                        new
                        {
                            Id = 12,
                            Color = "White",
                            Make = "Nissan",
                            Mileage = "37665",
                            Model = "Sentra",
                            Price = "13900",
                            Year = 2018
                        },
                        new
                        {
                            Id = 13,
                            Color = "Tan",
                            Make = "Subaru",
                            Mileage = "65360",
                            Model = "Crosstrek 2.0i Premium",
                            Price = "13900",
                            Year = 2014
                        },
                        new
                        {
                            Id = 14,
                            Color = "Blue",
                            Make = "Hyundai",
                            Mileage = "29059",
                            Model = "Elantra Sedan",
                            Price = "13900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 15,
                            Color = "White",
                            Make = "Hyundai",
                            Mileage = "25474",
                            Model = "Elantra Sedan w/ CARGO PACKAGE",
                            Price = "14900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 16,
                            Color = "Black",
                            Make = "Dodge",
                            Mileage = "70812",
                            Model = "Grand Caravan SXT",
                            Price = "14900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 17,
                            Color = "Silver",
                            Make = "Jeep",
                            Mileage = "73122",
                            Model = "Cherokee 4WD Sport",
                            Price = "14900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 18,
                            Color = "Red",
                            Make = "Chevrolet",
                            Mileage = "20560",
                            Model = "Cruze LT Sedan",
                            Price = "14900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 19,
                            Color = "Red",
                            Make = "Hyundai",
                            Mileage = "24851",
                            Model = "Elantra Sedan",
                            Price = "14900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 20,
                            Color = "Black",
                            Make = "Cadillac",
                            Mileage = "69141",
                            Model = "CTS Sedan w/ SEATING PACKAGE",
                            Price = "14900",
                            Year = 2014
                        },
                        new
                        {
                            Id = 21,
                            Color = "White",
                            Make = "Dodge",
                            Mileage = "70133",
                            Model = "Grand Caravan SXT",
                            Price = "15495",
                            Year = 2016
                        },
                        new
                        {
                            Id = 22,
                            Color = "Gray",
                            Make = "Nissan",
                            Mileage = "14808",
                            Model = "Altima",
                            Price = "15900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 23,
                            Color = "Silver",
                            Make = "Chevrolet",
                            Mileage = "21027",
                            Model = "Trax AWD LS",
                            Price = "15900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 24,
                            Color = "Red",
                            Make = "Nissan",
                            Mileage = "53087",
                            Model = "Rogue AWD w/ SV PREMIUM PACKAGE",
                            Price = "15900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 25,
                            Color = "White",
                            Make = "Chevrolet",
                            Mileage = "2928",
                            Model = "Sonic LT Sedan w/ RS PACKAGE",
                            Price = "15900",
                            Year = 2019
                        },
                        new
                        {
                            Id = 26,
                            Color = "Gray",
                            Make = "Dodge",
                            Mileage = "68671",
                            Model = "Grand Caravan SXT",
                            Price = "15900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 27,
                            Color = "Red",
                            Make = "Buick",
                            Mileage = "17734",
                            Model = "Encore FWD Convenience",
                            Price = "15900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 28,
                            Color = "Gray",
                            Make = "Buick",
                            Mileage = "40059",
                            Model = "Encore AWD",
                            Price = "15900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 29,
                            Color = "Silver",
                            Make = "Jeep",
                            Mileage = "71164",
                            Model = "Wrangler 4WD Sahara",
                            Price = "15900",
                            Year = 2008
                        },
                        new
                        {
                            Id = 30,
                            Color = "Silver",
                            Make = "Chevrolet",
                            Mileage = "42687",
                            Model = "Malibu LT",
                            Price = "15900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 31,
                            Color = "Red",
                            Make = "Hyundai",
                            Mileage = "30066",
                            Model = "Sonata SE",
                            Price = "15900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 32,
                            Color = "Gray",
                            Make = "Nissan",
                            Mileage = "52533",
                            Model = "Altima",
                            Price = "15900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 33,
                            Color = "Yellow",
                            Make = "Ford",
                            Mileage = "8040",
                            Model = "Focus SE Hatchback",
                            Price = "15900",
                            Year = 2018
                        },
                        new
                        {
                            Id = 34,
                            Color = "Blue",
                            Make = "Honda",
                            Mileage = "76904",
                            Model = "Civic Si Coupe",
                            Price = "15900",
                            Year = 2015
                        },
                        new
                        {
                            Id = 35,
                            Color = "Black",
                            Make = "Ford",
                            Mileage = "61089",
                            Model = "Explorer 4WD",
                            Price = "15900",
                            Year = 2013
                        },
                        new
                        {
                            Id = 36,
                            Color = "White",
                            Make = "Nissan",
                            Mileage = "30478",
                            Model = "Altima",
                            Price = "16495",
                            Year = 2017
                        },
                        new
                        {
                            Id = 37,
                            Color = "Silver",
                            Make = "Cadillac",
                            Mileage = "64693",
                            Model = "XTS Luxury",
                            Price = "16900",
                            Year = 2013
                        },
                        new
                        {
                            Id = 38,
                            Color = "White",
                            Make = "Ford",
                            Mileage = "29494",
                            Model = "Fusion SE",
                            Price = "16900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 39,
                            Color = "Red",
                            Make = "Nissan",
                            Mileage = "36416",
                            Model = "Altima",
                            Price = "16900",
                            Year = 2018
                        },
                        new
                        {
                            Id = 40,
                            Color = "Blue",
                            Make = "Nissan",
                            Mileage = "8749",
                            Model = "Sentra",
                            Price = "16900",
                            Year = 2019
                        },
                        new
                        {
                            Id = 41,
                            Color = "Red",
                            Make = "Dodge",
                            Mileage = "38075",
                            Model = "Grand Caravan SE",
                            Price = "16900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 42,
                            Color = "Black",
                            Make = "Chevrolet",
                            Mileage = "35675",
                            Model = "Equinox AWD LS",
                            Price = "16900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 43,
                            Color = "Red",
                            Make = "GMC",
                            Mileage = "34019",
                            Model = "Terrain AWD SLE w/ SLE-1",
                            Price = "16900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 44,
                            Color = "Blue",
                            Make = "Hyundai",
                            Mileage = "62375",
                            Model = "Santa Fe AWD Sport w/ OPTION GROUP 03",
                            Price = "17495",
                            Year = 2016
                        },
                        new
                        {
                            Id = 45,
                            Color = "Silver",
                            Make = "Chevrolet",
                            Mileage = "37334",
                            Model = "Equinox AWD LT w/ CONVENIENCE PACKAGE",
                            Price = "17900",
                            Year = 2017
                        },
                        new
                        {
                            Id = 46,
                            Color = "White",
                            Make = "Buick",
                            Mileage = "49013",
                            Model = "Encore AWD Premium",
                            Price = "17900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 47,
                            Color = "Silver",
                            Make = "Honda",
                            Mileage = "73227",
                            Model = "CR-V AWD EX-L",
                            Price = "17900",
                            Year = 2015
                        },
                        new
                        {
                            Id = 48,
                            Color = "Blue",
                            Make = "MAZDA",
                            Mileage = "45925",
                            Model = "CX-3 Grand Touring",
                            Price = "17900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 49,
                            Color = "Orange",
                            Make = "Hyundai",
                            Mileage = "32063",
                            Model = "Tucson AWD",
                            Price = "17900",
                            Year = 2016
                        },
                        new
                        {
                            Id = 50,
                            Color = "Red",
                            Make = "Toyota",
                            Mileage = "69173",
                            Model = "RAV4 AWD Limited",
                            Price = "17900",
                            Year = 2015
                        },
                        new
                        {
                            Id = 51,
                            Color = "Gray",
                            Make = "Honda",
                            Mileage = "65000",
                            Model = "Civic",
                            Price = "9000",
                            Year = 2010
                        },
                        new
                        {
                            Id = 52,
                            Color = "Red",
                            Make = "Geo",
                            Mileage = "300000",
                            Model = "Prism",
                            Price = "100",
                            Year = 1999
                        },
                        new
                        {
                            Id = 53,
                            Color = "Blue",
                            Make = "Ford",
                            Mileage = "30000",
                            Model = "Fiesta",
                            Price = "12000",
                            Year = 2017
                        },
                        new
                        {
                            Id = 54,
                            Color = "Silver",
                            Make = "SpaceX",
                            Mileage = "760300",
                            Model = "Civilian Space Commuter",
                            Price = "150000",
                            Year = 2015
                        });
                });
#pragma warning restore 612, 618
        }
    }
}