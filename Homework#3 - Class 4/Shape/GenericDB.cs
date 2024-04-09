using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Domain.Models;

namespace Shapes
{
    public class GenericDB<T> where T : Shape
    {
        private List<T> shapes = new List<T>();

        public void AddShape(T shape)
        {
            shapes.Add(shape);
        }
        public void PrintAreas()
        {
            foreach (T shape in shapes)
            {
                Console.WriteLine($"Area of shape with Id {shape.Id}: {shape.GetArea()}");
            }
        }

        public void PrintPerimeter() 
        {
            foreach (T shape in shapes) 
            {
                Console.WriteLine($"Perimeter of shape with Id {shape.Id}: {shape.GetPerimeter()}");
            }
        }
    }
}
