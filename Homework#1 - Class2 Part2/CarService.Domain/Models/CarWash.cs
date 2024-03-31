using CarService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public class CarWash : ICarWash
    {
        public void WashCar()
        {
            Console.WriteLine("Car is being washed.");

        }

        public void WashTrailer()
        {
            Console.WriteLine($"Truck is being washed.");

        }
    }
}
