using System;
using UserManagement.Api;

namespace UserManagement.Service
{
    public class UserService : IUserService
    {
        public void CreateUser(string email, string firstName, string lastName, string rawPassword, DateTime dateOfBirth)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserByEmail(string email, string firstName, string lastName, string rawPassword, DateTime dateOfBirth)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}