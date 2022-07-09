using System.Linq.Expressions;

namespace Kubesharp.Service.Command.Impl;

internal class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    public Task<bool> AddAsync(
        T entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddManyAsync(
        IEnumerable<T> entities, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<long> CountAsync(
        Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(
        Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<long> DeleteManyAsync(
        Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<T?> FindAsync(
        Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> SaveAsync(
        T entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(
        Expression<Func<T, bool>> expression, T entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
