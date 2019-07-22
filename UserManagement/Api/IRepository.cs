using System.Linq;

namespace UserManagement.Api
{
    public interface IRepository<T>
    {
        T Save(T entity);

        T Update(T entity);

        void Delete(T entity);

        IQueryable<T> Query();
    }
}