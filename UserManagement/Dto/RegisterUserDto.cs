using System;

namespace UserManagement.Dto
{
    public class RegisterUserDto
    {

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public string Email { set; get; }

        public string RawPassword { set; get; }

        public DateTime DateOfBirth { set; get; }
    }
}