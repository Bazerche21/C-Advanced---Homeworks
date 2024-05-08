using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.DomainInterfaces;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.Database
{
    public class UserRepository : IUser
    {
        private List<User> _users;

        public UserRepository() {
            _users = new List<User>();
        }
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void DeleteUser(User userId)
        {
            _users.Remove(userId);
        }

        public User GetUserByUsername(string username)
        {
            return _users.Find(u => u.Username == username);
        }

        public void UpdateUser(User user)
        {
            int index = _users.FindIndex(u => u.Username == user.Username);
            if (index != -1)
            {
                _users[index] = user;
            }
            else
            {
                throw new Exception("User not found");
            }
        }
    }
}
