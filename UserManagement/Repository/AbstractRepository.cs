using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserManagement.Api;

namespace UserManagement.Repository
{
    public class AbstractRepository<T> : IRepository<T>, IAsyncRepository<T> where T : class
    {
        private protected readonly DbContext _context;
        private protected readonly DbSet<T> _set;

        protected AbstractRepository(DbContext context, DbSet<T> set)
        {
            _context = context;
            _set = set;
        }

        public T Save(T entity)
        {
            var entityEntry = _set.Add(entity);
            _context.SaveChanges();

            return entityEntry.Entity;
        }

        public T Update(T entity)
        {
            var entityEntry = _set.Update(entity);
            _context.SaveChanges();

            return entityEntry.Entity;
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> Query()
        {
            return _context.Query<T>();
        }

        public async Task<T> SaveAsync(T entity)
        {
            return await Task.Run(() => Save(entity));
        }

        public async Task<T> UpdateAsync(T entity)
        {
            return await Task.Run(() => Update(entity));
        }

        public async void DeleteAsync(T entity)
        {
            await Task.Run(() => Delete(entity));
        }

        public async Task<IQueryable<T>> QueryAsync()
        {
            return await Task.Run(Query);
        }
    }
}