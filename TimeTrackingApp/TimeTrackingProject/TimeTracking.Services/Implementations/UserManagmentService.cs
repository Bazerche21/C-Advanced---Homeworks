using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.DomainInterfaces;
using TimeTracking.Domain.Models;
using TimeTracking.Services.Helpers;
using TimeTracking.Services.Interfaces;

namespace TimeTracking.Services.Implementations
{
    public class UserManagmentService<T> : IUserManagmentService<T> where T : User
    {
        private readonly IDatabase<T> _database;

        public UserManagmentService(IDatabase<T> database)
        {
            _database = database;
        }
        public T ChangeFirstName(int userId, string firstName)
        {
            T userDb = _database.GetById(userId);
            if (!ValidationHelper.ValidateFirstName(firstName))
            {
                MessageHelper.PrintMessage("[Error] Invalid user data", ConsoleColor.Red);
                return null;
            }

            userDb.FirstName = firstName;
            _database.Update(userDb);
            MessageHelper.PrintMessage($"User first name with id {userId} was successfully updated", ConsoleColor.Green);
            return _database.GetById(userId);
        }

        public T ChangeLastName(int userId, string lastName)
        {
            T userDb = _database.GetById(userId);
            if (!ValidationHelper.ValidateLastName(lastName))
            {
                MessageHelper.PrintMessage("[Error] Invalid user data", ConsoleColor.Red);
                return null;
            }

            userDb.LastName = lastName;
            _database.Update(userDb);
            MessageHelper.PrintMessage($"User last name with id {userId} was successfully updated", ConsoleColor.Green);
            return _database.GetById(userId);
        }

        public void ChangePassword(int userId, string oldPassword, string newPassword)
        {
            T userDb = _database.GetById(userId);
            if (userDb != null)
                throw new Exception($"User with id {userId} was not found");

            if (userDb.Password != oldPassword)
                throw new Exception($"Old passwords do not match!");

            if (!ValidationHelper.ValidatePassword(newPassword))
                throw new Exception("Invalid password");

            userDb.Password = newPassword;
            _database.Update(userDb);
        }

        public void DeactivateAccount(int userId)
        {
            T userDb = _database.GetById(userId);
            if (userDb == null)
            {
                Console.WriteLine("User not found.");
                return;
            }
            userDb.isActive = false;
            _database.DeleteUser(userId);
            _database.Update(userDb);
            MessageHelper.PrintMessage($"Account with ID {userId} has been deactivated", ConsoleColor.Green);
        }
    }
}
