using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Employee.Domain.Models
{
    public class Manager : Employee
    {
        public double Salary { get; set; }
        public double Bonus { get; set; }

        public Manager(string name, string employeeId, double salary, double bonus) : base(name, employeeId)
        {
            Salary = salary;
            Bonus = bonus;
        }

        public override double CalculateSalary()
        {
            return Salary + Bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}, EmployeeID:{EmployeeId}, Salary:{CalculateSalary()}");
        }
    }
}
