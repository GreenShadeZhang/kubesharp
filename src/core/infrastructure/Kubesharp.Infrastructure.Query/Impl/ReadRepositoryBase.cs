using System.Linq.Expressions;

namespace Kubesharp.Service.Query.Impl;

public class ReadRepositoryBase<T> : IReadRepositoryBase<T> where T : class
{
    public Task<long> CountAsync(
        Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<T?> FindAsync(
        Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
