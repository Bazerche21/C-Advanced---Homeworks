using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Domain.DomainInterfaces
{
    public interface IUserManagmentService<T> where T : User
    {
        T ChangeFirstName(int userId, string firstName);
        T ChangePassword(int userId, string password);
        T ChangeLastName(int userId, string lastName);
        void DeactivateAccount(int userId);
    }
}
