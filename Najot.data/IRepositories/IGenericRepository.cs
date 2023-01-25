using NajotEdu.ru.Najot.Domain.AbstractEntities;
using System.Linq.Expressions;

namespace NajotEdu.ru.Najot.data.IRepositories
{
    public interface IGenericRepository<T> where T : Auditable
    {
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAllAsync(Expression<Func<T, bool>> predicate);
    }
}
