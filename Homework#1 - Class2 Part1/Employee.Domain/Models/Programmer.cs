using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Domain.Models
{
    public class Programmer : Employee
    {
        public double Salary { get; set; }
        public int OvertimeHours { get; set; }

        public Programmer(string name, string employeeId, double salary, int overtimeHours) : base(name, employeeId)
        {
            Salary = salary;
            OvertimeHours = overtimeHours;
        }

        public override double CalculateSalary()
        {
            return Salary + (OvertimeHours * 14);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}, EmployeeID:{EmployeeId}, Salary:{CalculateSalary()}");
        }
    }
}
