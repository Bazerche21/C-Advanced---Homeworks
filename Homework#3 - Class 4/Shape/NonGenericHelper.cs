using Shapes.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class NonGenericHelper
    {
        public static void PrintInfo(Circle circle)
        {
            Console.WriteLine($"Circle with Id {circle.Id}: Radius = {circle.Radius}, Area = {circle.GetArea()}, Perimeter = {circle.GetPerimeter()}");
        }

        public static void PrintInfo(Rectangle rectangle)
        {
            Console.WriteLine($"Rectangle with Id {rectangle.Id}: SideA = {rectangle.SideA}, SideB = {rectangle.SideB}, Area = {rectangle.GetArea()}, Perimeter = {rectangle.GetPerimeter()}");
        }
    }
}
