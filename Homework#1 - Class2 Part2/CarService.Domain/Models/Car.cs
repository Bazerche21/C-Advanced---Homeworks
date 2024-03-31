namespace CarService.Domain.Models
{
    public class Car : Vehicle
    {
        public Car(string manufacturer, string model, int yearOfProduction, int horsePower) : base(manufacturer, model, yearOfProduction, horsePower)
        {
        }
        public override void Drive()
        {
            Console.WriteLine($"The {Model} is being driven.");
        }
    }
}
