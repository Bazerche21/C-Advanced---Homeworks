using Shapes;
using Shapes.Domain.Models;

NonGenericHelper nonGenericHelper = new NonGenericHelper();

Circle circle = new(1, 3);
Rectangle rectangle = new(2, 5, 9);

NonGenericHelper.PrintInfo(circle);
NonGenericHelper.PrintInfo(rectangle);