using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Database;
using TimeTracking.Domain.Models;
using TimeTracking.Services.Helpers;
using TimeTracking.Services.Interfaces;

namespace TimeTracking.Services.Implementations
{
    public class AuthenticationService<T> : IAuthenticationService<T> where T : User
    {
        public IDatabase<T> _database;

        public AuthenticationService(IDatabase<T> database)
        {
            _database = database;
        }

        public T LogIn(string username, string password)
        {
            T userDb = _database.GetAll().FirstOrDefault(x => x.Username == username && x.Password == password);
            if (userDb == null)
            {
                MessageHelper.PrintMessage($"[Error User with username {username} does not exists", ConsoleColor.Red);
                return null;
            }
            return userDb;
        }

        public T LogOut()
        {
            throw new NotImplementedException();
        }

        public T Register(User userModel)
        {
            if (!ValidationHelper.ValidateFirstAndLastName(userModel.FirstName, userModel.LastName )|| !ValidationHelper.ValidateUsername(user.Username) || !ValidationHelper.ValidatePassword(userModel.Password))
            {
                MessageHelper.PrintMessage("[Error] User data is invalid", ConsoleColor.Red);
                return null;
            }
            int id = _database.Insert(userModel);
            return _database.GetById(id);
        }
    }
}
