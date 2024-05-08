using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.DomainInterfaces
{
    public interface IUser
    {
        void AddUser(User user);
        User GetUserByUsername(string username);
        void UpdateUser(User user);
        void DeleteUser(User userId);
    }
}
