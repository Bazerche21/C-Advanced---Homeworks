
using Dogs.Domain.Database;
using Dogs.Domain.Entities;

DogDb dogDb = new DogDb();
void Seed()
{
    if (dogDb.GetAll().Count == 0)
    {
        Console.WriteLine("======= INSERTING DOGS =======");
        dogDb.Insert(new Dog("Buddy", 3, "Golden"));
        dogDb.Insert(new Dog("Max", 2, "Black"));
        dogDb.Insert(new Dog("Bella", 5, "White"));
    }
}

Seed();
Console.WriteLine("======= TESTING =======");

List<Dog> dogs = dogDb.GetAll();

Console.WriteLine("======= GET ALL =======");
foreach (Dog dog in dogs)
{
    Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
}

Console.WriteLine("======= GET BY ID =======");
Console.WriteLine(dogDb.GetById(2).ToString());
Console.ReadLine();
Console.Clear();

Console.WriteLine("======= CREATE NEW DOG =======");
Console.WriteLine("Enter Dog's Name: ");
string name = Console.ReadLine();
Console.WriteLine("Enter Dog's Age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Dog's Color: ");
string color = Console.ReadLine();
Dog newDog = new Dog(name, age, color);
dogDb.Insert(newDog);
Console.WriteLine("======= DOG CREATED =======");
Console.ReadLine();

Console.WriteLine("======= GET ALL AGAIN =======");
Console.Clear();
foreach (Dog dog in dogDb.GetAll())
{
    Console.WriteLine($"Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
}
Console.ReadLine();

Console.WriteLine("Do you want to clear the DB? (y/n)");
string answer = Console.ReadLine();
if (answer.ToLower() == "y")
{
    dogDb.ClearDb();
}
else
{
    Console.WriteLine("Goodbye!");
}
Console.ReadLine();

Console.WriteLine("======= PRINTING ALL DOGS FROM FILE =======");
dogDb.PrintAllDogsFromFile();