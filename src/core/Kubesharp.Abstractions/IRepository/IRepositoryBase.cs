using System.Linq.Expressions;

namespace Kubesharp.Abstractions.IRepository;

public interface IRepositoryBase<T> : IReadRepositoryBase<T> where T : class
{
    Task<bool> SaveAsync(T entity, CancellationToken cancellationToken = default);
    Task<bool> AddAsync(T entity, CancellationToken cancellationToken = default);
    Task<bool> AddManyAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default);
    Task<bool> UpdateAsync(Expression<Func<T, bool>> expression, T entity, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    Task<long> DeleteManyAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
}
