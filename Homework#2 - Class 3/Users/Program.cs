using Users.Domain.Models;
using Users.Domain.Database;

User user1 = new User(1, "Lazar", 25);
User user2 = new User(2, "Petar", 29);
User user3 = new User(3, "Kristijan", 19);
User user4 = new User(4, "Marija", 22);
User user5 = new User(5, "Elizabeta", 24);
User user6 = new User(6, "Bistra", 18);
User user7 = new User(7, "Marko", 29);
User user8 = new User(8, "Marija", 39);

UserDatabase.AddUser(user1);
UserDatabase.AddUser(user2);
UserDatabase.AddUser(user3);
UserDatabase.AddUser(user4);  
UserDatabase.AddUser(user5);
UserDatabase.AddUser(user6);
UserDatabase.AddUser(user7);
UserDatabase.AddUser(user8);

User userById = UserDatabase.SearchById(2);
List<User> usersByName = UserDatabase.SearchByName("Marija");
List<User> usersByAge = UserDatabase.SearchByAge(29);

Console.WriteLine($"Users found by ID: {userById.Id}, Name: {userById.Name}, Age: {userById.Age}");

Console.WriteLine("\nUsers found by Name:");
foreach (var user in usersByName)
{
    Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}

Console.WriteLine("\nUsers found by Age:");
foreach (var user in usersByAge)
{
    Console.WriteLine($"ID: {user.Id}, Name: {user.Name}, Age: {user.Age}");
}
