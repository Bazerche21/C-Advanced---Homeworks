using CarService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        private bool isClean = false;
        private bool isBroken = false;
        private bool isGasFull = false;
        public void CheckVehicle()
        {
            Console.WriteLine("Vehicle is being checked for repairs.");
            isBroken = true;
        }

        public void FixVehicle()
        {
            Console.WriteLine("Vehicle is being fixed.");
            isBroken = false;
        }

        public void PumpGas()
        {
            Console.WriteLine("Gas is being pumped into the vehicle.");
            isGasFull = true;
        }

        public void WashCar()
        {
            Console.WriteLine("Car is being washed.");
            isClean = true;
        }

        public void WashTrailer()
        {
            Console.WriteLine("Truck is being washed.");
            isClean = true;
        }

        public void ServiceVehicle(Vehicle vehicle)
        {
            if (vehicle is Car)
            {
                WashCar();
                PumpGas();
                CheckVehicle();
                if (isBroken)
                    FixVehicle();
                Console.WriteLine("Car service completed.");
            }
            else if (vehicle is Truck)
            {
                WashTrailer();
                PumpGas();
                CheckVehicle();
                if (isBroken)
                    FixVehicle();
                Console.WriteLine("Truck service completed.");
            }
            else
            {
                Console.WriteLine("Unsupported vehicle type.");
            }
        }
    }
}
