using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace KnaseAsg5Dealer.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1960, 2020, ErrorMessage = "Year must be between 1960 and 2020.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a make.")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter a model.")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please enter a price.")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Please enter mileage.")]
        public string Mileage { get; set; }

        [Required(ErrorMessage = "Please enter a color.")]
        public string Color { get; set; }      
    }
}
