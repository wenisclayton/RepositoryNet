using System.Linq.Expressions;
using RepositoryNet.Entities;
using RepositoryNet.Interface;

namespace RepositoryNet
{
    public class RepositoryAsync<T> : IRepositoryAsync<T> where T : EntityBase
    {
        public async Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetFirstAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Entities { get; }
    }
}
