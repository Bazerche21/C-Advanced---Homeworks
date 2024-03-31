using Animal.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Domain.Models
{
    public class Dog : Animal, IDog
    {
        public Dog(string name, int age, string color) : base(name, age, color)
        {
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} barks Woof Woof!!");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"Dog: {Name}, Age: {Age}, Color: {Color}");
        }
    }
}
