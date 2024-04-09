using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Domain.Models
{
    public class Rectangle : Shape
    { 
        public double SideA { get; set; }
        public double SideB { get; set; }
        public Rectangle(int id, double sideA, double sideB) : base(id)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public override double GetArea()
        {
            return SideA * SideB;
        }

        public override double GetPerimeter()
        {
            return 2 * (SideA + SideB);
        }
    }
}
