using Animal.Domain.Interfaces;
using Animal.Domain.Models;

Dog dog = new("Skaj", 3, "White");
Cat cat = new("Runte", 5, "Brown");

dog.PrintAnimal();
dog.Bark();

cat.PrintAnimal();
cat.Eat("fish");
