using System.Linq;
using Microsoft.EntityFrameworkCore;
using UserManagement.Api;
using UserManagement.Context;
using UserManagement.Model;

namespace UserManagement.Repository
{
    public class UserRepository : AbstractRepository<User>
    {
        public UserRepository(ApplicationContext context) : base(context, context.Users)
        {
        }

        public User FindUserByEmailLINQ(string email)
        {
            return Query().First(user => email.Equals(user.Email));
        }

        public User FindUserByEmailSQL(string email)
        {
            return Query().FromSql($"SELECT * FROM User u WHERE u.email = {email}").First();
        }

        public User FindUserById(long id)
        {
            return Query().First(user => id.Equals(user.Id));
        }
    }
}