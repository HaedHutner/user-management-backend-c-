using System;
using System.Collections.Generic;

namespace UserManagement.Dto
{
    public class UserDto
    {
        public long Id { set; get; }

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public string Email { set; get; }

        public string RawPassword { get; set; }

        public DateTime DateOfBirth { set; get; }

        public List<AddressDto> Addresses { set; get; }
    }
}