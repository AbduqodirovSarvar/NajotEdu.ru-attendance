using NajotEdu.ru.Najot.Domain.AbstractEntities;
using System.Linq.Expressions;

namespace NajotEdu.ru.Najot.data.IRepositories
{
    public interface IGenericRepository<T> where T : Auditable
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(int id, T entity);
        Task<T> DeleteAsync(int id);
        Task<T> GetAsync(int id);
        Task<T> GetAllAsync(Expression<Func<T, bool>> predicate);
    }
}
