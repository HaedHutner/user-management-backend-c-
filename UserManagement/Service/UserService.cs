using System;
using UserManagement.Api;
using UserManagement.Model;
using UserManagement.Repository;

namespace UserManagement.Service
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        private readonly PasswordService _passwordService;
        public UserService(UserRepository userRepository, PasswordService passwordService)
        {
            _userRepository = userRepository;
            _passwordService = passwordService;
        }

        public User CreateUser(string email, string firstName, string lastName, string rawPassword, DateTime dateOfBirth)
        {
            var user = new User
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                PasswordHash = _passwordService.HashPassword(rawPassword),
                DateOfBirth = dateOfBirth
            };

            return user;
        }

        public void UpdateUserById(long id, string valueEmail, string firstName, string lastName, string rawPassword, DateTime dateOfBirth)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserById(long id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(long id)
        {
            return _userRepository.FindUserById(id);
        }
    }
}