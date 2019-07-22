using System.Linq;
using UserManagement.Api;
using UserManagement.Model;

namespace UserManagement.Repository
{
    public class UserRepository : IRepository<User>
    {
        public User Save(User entity)
        {
            throw new System.NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<User> Query()
        {
            throw new System.NotImplementedException();
        }
    }
}