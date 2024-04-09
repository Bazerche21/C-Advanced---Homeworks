using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Domain.Models;

namespace Users.Domain.Database
{
    public static class UserDatabase
    {
        private static List<User> Users { get; set; }

        static UserDatabase()
        {
            Users = new List<User>();

            new Models.User(1, "Lazar", 25);
            new Models.User(2, "Petar", 29);
            new Models.User(3, "Kristijan", 19);
            new Models.User(4, "Marija", 22);
            new Models.User(5, "Elizabeta", 24);
            new Models.User(6, "Bistra", 18);
            new Models.User(7, "Marko", 35);
            new Models.User(8, "Mirko", 39);

        }

        public static Models.User SearchById(int id)
        {
            return Users.FirstOrDefault(user => user.Id == id);
        }

        public static List<Models.User> SearchByName(string name)
        {
            return Users.Where(user => user.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Models.User> SearchByAge(int age)
        {
            return Users.Where(user => user.Age == age).ToList();
        }
    }
}
