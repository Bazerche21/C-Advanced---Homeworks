using TimeTracking.Domain.Models;

namespace TimeTracking.Services.Interfaces
{
    public interface IUserManagmentService<T> where T : User
    {
        T ChangeFirstName(int userId, string firstName);
        void ChangePassword(int userId,string oldPassword, string newPassword);
        T ChangeLastName(int userId, string lastName);
        void DeactivateAccount(int userId);
    }
}