using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracking.Domain.Models;

namespace TimeTracking.Services.Interfaces
{
    public interface IAuthenticationService<T> where T : User
    {
        T Register(User userModel);
        T LogIn(string username, string password);
        T LogOut();
    }
}
