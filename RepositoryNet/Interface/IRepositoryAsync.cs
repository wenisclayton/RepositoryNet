using System.Linq.Expressions;
using RepositoryNet.Entities;

namespace RepositoryNet.Interface
{
    public interface IRepositoryAsync<T> where T: EntityBase
    {
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        IQueryable<T> GetAll(T entity);
        Task<T> GetByIdAsync(Guid id);
        Task UpdateAsync(T entity);
        Task<T> GetFirstAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> Entities { get; }
    }
}
