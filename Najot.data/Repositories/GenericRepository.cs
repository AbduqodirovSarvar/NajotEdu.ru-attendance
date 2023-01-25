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
        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAllAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}
