namespace Shapes.Domain.Models
{
    public abstract class Shape
    {
        public int Id { get; set; }

        public Shape(int id)
        {
            Id = id;
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
