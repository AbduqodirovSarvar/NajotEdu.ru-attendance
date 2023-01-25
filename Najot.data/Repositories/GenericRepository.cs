using Microsoft.EntityFrameworkCore;
using NajotEdu.ru.Najot.data.DbContexts;
using NajotEdu.ru.Najot.data.IRepositories;
using NajotEdu.ru.Najot.Domain.AbstractEntities;
using System.Linq.Expressions;

namespace NajotEdu.ru.Najot.data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Auditable
    {
        protected readonly AppDbContext _db;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext dbcontext)
        {
            _db = dbcontext;
            _dbSet = dbcontext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {

            _dbSet.Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public IEnumerable<T> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            return predicate is null? _dbSet : _dbSet.Where(predicate);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task UpdateAsync(int id, T entity)
        {
            entity.Id = id;
            var result = _dbSet.Update(entity);
            await _db.SaveChangesAsync();
        }

    }
}
