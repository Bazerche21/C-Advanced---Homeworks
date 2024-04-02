namespace Employee.Domain.Models
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string EmployeeId { get; set; }

        public Employee(string name, string employeeId)
        {
            Name = name;
            EmployeeId = employeeId;
        }

        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}
