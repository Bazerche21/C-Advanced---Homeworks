using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public class Truck : Vehicle
    {
        public Truck(string manufacturer, string model, int yearOfProduction, int horsePower) : base(manufacturer, model, yearOfProduction, horsePower)
        {
        }
        public override void Drive()
        {
            Console.WriteLine($"The {Model} is being driven.");
        }
    }
}
