using Shapes;
using Shapes.Domain.Models;

GenericDB<Shape> genericDB = new GenericDB<Shape>();

Circle circle = new(1, 3);
Rectangle rectangle = new(2, 5, 9);

genericDB.AddShape(circle);
genericDB.AddShape(rectangle);

circle.PrintInfo();
rectangle.PrintInfo();

genericDB.PrintPerimeter();
genericDB.PrintAreas();