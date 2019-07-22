using System;
using UserManagement.Model;

namespace UserManagement.Api
{
    public interface IUserService
    {
        void CreateUser(string email, string firstName, string lastName, string rawPassword, DateTime dateOfBirth);

        void UpdateUserByEmail(string email, string firstName, string lastName, string rawPassword, DateTime dateOfBirth);

        void DeleteUserByEmail(string email);
    }
}