using CarService.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Domain.Models
{
    public class GasPump : IGasPump
    {
        public void PumpGas()
        {
            Console.WriteLine("Gas is being pumped into the vehicle.");
        }
    }
}
