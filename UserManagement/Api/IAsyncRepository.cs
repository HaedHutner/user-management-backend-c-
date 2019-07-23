using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Api
{
    public interface IAsyncRepository<T>
    {
        Task<T> SaveAsync(T entity);

        Task<T> UpdateAsync(T entity);

        void DeleteAsync(T entity);

        Task<IQueryable<T>> QueryAsync();
    }
}