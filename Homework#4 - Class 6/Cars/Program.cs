using Cars.Domain.Models;
using Cars.Domain.NewFolder;

List<Car> carsOriginEurope = CarsData.Cars.Where(x => x.Origin == "Europe").ToList();
Console.WriteLine("Cars that have origin from Europe:");
foreach (Car car in carsOriginEurope)
{
    Console.WriteLine($"Model: {car.Model}, MPG: {car.MilesPerGalon}, Acceleration: {car.AccelerationTime}s, Cylinders: {car.Cylinders}, HP: {car.HorsePower}, Weight: {car.Weight}, Origin: {car.Origin}");
}

List<Car> carsMoreThanSixCilinders = CarsData.Cars.Where(car => car.Cylinders > 6).ToList();
List<Car> carsExactFourCilinderMoreThan110HP = CarsData.Cars.Where(x => x.Cylinders == 4 && x.HorsePower > 110).ToList();

List<Car> result = carsMoreThanSixCilinders.Concat(carsExactFourCilinderMoreThan110HP).ToList();
Console.WriteLine("\nCars that have more than 6 Cilinders and Cars that have exact 4 Cilinders and more than 110 HorsePower");
foreach (Car car in result)
{
    Console.WriteLine($"Model: {car.Model}, Cylinders: {car.Cylinders}, HP: {car.HorsePower}, Origin: {car.Origin}");
}

List<string> countingCarsBasedOnTheirOrigin = CarsData.Cars.GroupBy(car => car.Origin).Select(group => $"{group.Key}: {group.Count()} models").ToList();
Console.WriteLine("\nCounting cars based on their origin:");
foreach(string car in countingCarsBasedOnTheirOrigin)
{
    Console.WriteLine($"{car}");
}

List<Car> carsMoreThen200HP = CarsData.Cars.Where(x=> x.HorsePower > 200).ToList();
Console.WriteLine("\nCars with more than 200HP and their lowest, highest and average Miles Per Galon:");
if (carsMoreThen200HP.Any())
{
    double lowestMpg = carsMoreThen200HP.Min(car => car.MilesPerGalon);
    double highestMpg = carsMoreThen200HP.Max(car => car.MilesPerGalon);
    double averageMpg = carsMoreThen200HP.Average(car => car.MilesPerGalon);

    Console.WriteLine($"Lowest MPG: {lowestMpg}");
    Console.WriteLine($"Highest MPG: {highestMpg}");
    Console.WriteLine($"Average MPG: {averageMpg}");
}
else
{
    Console.WriteLine("No cars found with more than 200 horsepower.");
}

Console.WriteLine("\nFind the Average Weight of Cars with 4 Cylinders");
List<Car> cars4Cylinders = CarsData.Cars.Where(car => car.Cylinders == 4).ToList();
if (cars4Cylinders.Any())
{
    double averageWeight = cars4Cylinders.Average(car => car.Weight);

    Console.WriteLine($"Average Weight of Cars with 4 Cylinders: {averageWeight} lbs");
}
else
{
    Console.WriteLine("No cars found with 4 cylinders.");
}

Console.WriteLine("\nSort Cars by Miles Per Gallon (MPG) in descending:");

List<Car> sortingCarsMPGDescending = CarsData.Cars.OrderByDescending(x => x.MilesPerGalon).ToList();

foreach(Car car in sortingCarsMPGDescending)
{
    Console.WriteLine($"Model: {car.Model}, MPG: {car.MilesPerGalon}");
}

Console.WriteLine("\nFind the Fastest Accelerating Car from Each Origin:");

List<Car> fastestAcceleratingCarEachOrigin = CarsData.Cars.GroupBy(car => car.Origin).Select(group => group.OrderBy(car => car.AccelerationTime).First()).ToList();

foreach( Car car in fastestAcceleratingCarEachOrigin)
{
    Console.WriteLine($"Origin: {car.Origin}, Model: {car.Model}, Acceleration Time: {car.AccelerationTime}s");
}