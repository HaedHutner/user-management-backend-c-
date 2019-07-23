using System;
using System.Collections.Generic;
using Microsoft.Net.Http.Headers;

namespace UserManagement.Model
{ 
    public class User
    {
        public long Id { set; get; }

        public string FirstName { set; get; }

        public string LastName { set; get; }

        public string Email { set; get; }

        public string PasswordHash { set; get; }

        public DateTime DateOfBirth { set; get; }

        public List<Address> Addresses { set; get; }
    }
}