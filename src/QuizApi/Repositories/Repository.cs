using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuizApi.Domain.Entities;
using QuizApi.Repositories.Abstractions;

namespace QuizApi.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : SimpleId
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        protected Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task DeleteAsync(int id)
        {
            _dbSet.Remove(await SelectByIdAsync(id).ConfigureAwait(false));
            await _context.SaveChangesAsync(true);
        }

        public virtual async Task<bool> ExistsAsync(int id) 
            => await _dbSet.AsNoTracking().AnyAsync(x => Equals(x.Id, id));

        public virtual async Task InsertAsync(TEntity entity)
        {
            if (await ExistsAsync(entity.Id).ConfigureAwait(false)) return;

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync(true);
        }


        public virtual async Task<TEntity> SelectByIdAsync(int id) 
            => await _dbSet.FindAsync(new object[] { id });

        public IQueryable<TEntity> SelectAll() => _dbSet;

        public async Task UpdateAsync(TEntity entity)
        {
            if (await ExistsAsync(entity.Id).ConfigureAwait(false) == false) return;

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}