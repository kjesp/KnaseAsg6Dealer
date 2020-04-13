using Microsoft.EntityFrameworkCore.Migrations;

namespace KnaseAsg5Dealer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    Make = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: false),
                    Mileage = table.Column<string>(nullable: false),
                    Color = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Make", "Mileage", "Model", "Price", "Year" },
                values: new object[,]
                {
                    { 1, "Silver", "Nissan", "84574", "Sentra", "8995", 2013 },
                    { 30, "Silver", "Chevrolet", "42687", "Malibu LT", "15900", 2016 },
                    { 31, "Red", "Hyundai", "30066", "Sonata SE", "15900", 2017 },
                    { 32, "Gray", "Nissan", "52533", "Altima", "15900", 2017 },
                    { 33, "Yellow", "Ford", "8040", "Focus SE Hatchback", "15900", 2018 },
                    { 34, "Blue", "Honda", "76904", "Civic Si Coupe", "15900", 2015 },
                    { 35, "Black", "Ford", "61089", "Explorer 4WD", "15900", 2013 },
                    { 36, "White", "Nissan", "30478", "Altima", "16495", 2017 },
                    { 37, "Silver", "Cadillac", "64693", "XTS Luxury", "16900", 2013 },
                    { 38, "White", "Ford", "29494", "Fusion SE", "16900", 2017 },
                    { 39, "Red", "Nissan", "36416", "Altima", "16900", 2018 },
                    { 40, "Blue", "Nissan", "8749", "Sentra", "16900", 2019 },
                    { 41, "Red", "Dodge", "38075", "Grand Caravan SE", "16900", 2016 },
                    { 42, "Black", "Chevrolet", "35675", "Equinox AWD LS", "16900", 2017 },
                    { 43, "Red", "GMC", "34019", "Terrain AWD SLE w/ SLE-1", "16900", 2016 },
                    { 44, "Blue", "Hyundai", "62375", "Santa Fe AWD Sport w/ OPTION GROUP 03", "17495", 2016 },
                    { 45, "Silver", "Chevrolet", "37334", "Equinox AWD LT w/ CONVENIENCE PACKAGE", "17900", 2017 },
                    { 46, "White", "Buick", "49013", "Encore AWD Premium", "17900", 2016 },
                    { 47, "Silver", "Honda", "73227", "CR-V AWD EX-L", "17900", 2015 },
                    { 48, "Blue", "MAZDA", "45925", "CX-3 Grand Touring", "17900", 2016 },
                    { 49, "Orange", "Hyundai", "32063", "Tucson AWD", "17900", 2016 },
                    { 50, "Red", "Toyota", "69173", "RAV4 AWD Limited", "17900", 2015 },
                    { 51, "Gray", "Honda", "65000", "Civic", "9000", 2010 },
                    { 52, "Red", "Geo", "300000", "Prism", "100", 1999 },
                    { 29, "Silver", "Jeep", "71164", "Wrangler 4WD Sahara", "15900", 2008 },
                    { 28, "Gray", "Buick", "40059", "Encore AWD", "15900", 2016 },
                    { 27, "Red", "Buick", "17734", "Encore FWD Convenience", "15900", 2016 },
                    { 26, "Gray", "Dodge", "68671", "Grand Caravan SXT", "15900", 2017 },
                    { 2, "Blue", "Chevrolet", "35304", "Spark LS", "8995", 2014 },
                    { 3, "Blue", "Ford", "70873", "Escape 4WD SE", "10900", 2013 },
                    { 4, "White", "Kia", "54691", "Soul", "10900", 2014 },
                    { 5, "Green", "Hyundai", "72115", "Tucson AWD", "11900", 2013 },
                    { 6, "Red", "Nissan", "44013", "Versa", "11900", 2018 },
                    { 7, "Silver", "Chevrolet", "94401", "Equinox AWD LS", "11900", 2015 },
                    { 8, "Red", "Kia", "72751", "Sedona LX", "11900", 2015 },
                    { 9, "White", "Hyundai", "49369", "Veloster", "11900", 2016 },
                    { 10, "White", "Cadillac", "76443", "DTS Luxury", "12900", 2011 },
                    { 11, "Blue", "Chevrolet", "28232", "Malibu LS w/ PROTECTION PACKAGE", "12900", 2014 },
                    { 12, "White", "Nissan", "37665", "Sentra", "13900", 2018 },
                    { 53, "Blue", "Ford", "30000", "Fiesta", "12000", 2017 },
                    { 13, "Tan", "Subaru", "65360", "Crosstrek 2.0i Premium", "13900", 2014 },
                    { 15, "White", "Hyundai", "25474", "Elantra Sedan w/ CARGO PACKAGE", "14900", 2017 },
                    { 16, "Black", "Dodge", "70812", "Grand Caravan SXT", "14900", 2016 },
                    { 17, "Silver", "Jeep", "73122", "Cherokee 4WD Sport", "14900", 2016 },
                    { 18, "Red", "Chevrolet", "20560", "Cruze LT Sedan", "14900", 2017 },
                    { 19, "Red", "Hyundai", "24851", "Elantra Sedan", "14900", 2017 },
                    { 20, "Black", "Cadillac", "69141", "CTS Sedan w/ SEATING PACKAGE", "14900", 2014 },
                    { 21, "White", "Dodge", "70133", "Grand Caravan SXT", "15495", 2016 },
                    { 22, "Gray", "Nissan", "14808", "Altima", "15900", 2017 },
                    { 23, "Silver", "Chevrolet", "21027", "Trax AWD LS", "15900", 2017 },
                    { 24, "Red", "Nissan", "53087", "Rogue AWD w/ SV PREMIUM PACKAGE", "15900", 2016 },
                    { 25, "White", "Chevrolet", "2928", "Sonic LT Sedan w/ RS PACKAGE", "15900", 2019 },
                    { 14, "Blue", "Hyundai", "29059", "Elantra Sedan", "13900", 2017 },
                    { 54, "Silver", "SpaceX", "760300", "Civilian Space Commuter", "150000", 2015 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
