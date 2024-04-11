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

        private static List<User> users = new List<User>();

        public static void AddUser(User user)
        {
            users.Add(user);
        }

        public static User SearchById(int id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }

        public static List<User> SearchByName(string name)
        {
            return users.Where(user => user.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return users.Where(user => user.Age == age).ToList();
        }
    }
}
