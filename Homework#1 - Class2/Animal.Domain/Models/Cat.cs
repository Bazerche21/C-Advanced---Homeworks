using Animal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Domain.Models
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, int age, string color) : base(name, age, color)
        {
        }

        public void Eat(string food)
        {
           Console.WriteLine($"{Name} is eating {food}.");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Dog: {Name}, Age: {Age}, Color: {Color}");
        }
    }
}
