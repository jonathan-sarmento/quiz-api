using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApi.Repositories.Abstractions
{
    public interface IRepository<TEntity>
    {
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        Task InsertAsync(TEntity entity);
        IQueryable<TEntity> SelectAll();
        Task<TEntity> SelectByIdAsync(int id);
        Task UpdateAsync(TEntity entity);
    }
}