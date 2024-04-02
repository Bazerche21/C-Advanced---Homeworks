using Employee.Domain.Models;

Manager manager = new("Laze Lazarevski", "M0247", 5000, 1000);
manager.DisplayInfo();

Console.WriteLine();

Programmer programmer = new("Meri Mijovska", "F0488", 4500, 15);
programmer.DisplayInfo();