using System;
using UserManagement.Model;

namespace UserManagement.Api
{
    public interface IUserService
    {
        User CreateUser(string email, string firstName, string lastName, string rawPassword, DateTime dateOfBirth);

        void UpdateUserById(long id, string email, string firstName, string lastName, string rawPassword, DateTime dateOfBirth);

        void DeleteUserById(long id);
        User GetUser(long id);
    }
}