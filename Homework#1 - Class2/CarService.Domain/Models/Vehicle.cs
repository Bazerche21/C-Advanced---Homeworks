using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public abstract class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearOfProduction { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(string manufacturer, string model, int yearOfProduction, int horsePower) 
        {
            Manufacturer = manufacturer;
            Model = model;
            YearOfProduction = yearOfProduction;
            HorsePower = horsePower;
        }
        public abstract void Drive();
    }
}
