using System.Linq.Expressions;

namespace Kubesharp.Abstractions.IRepository;

public interface IReadRepositoryBase<T> where T : class
{
    Task<long> CountAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    Task<T?> FindAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default);
    //Task<IEnumerable<T>> FindManyAsync(Expression<Func<T, bool>> expression, IOrderBy<T>? orderBy = default, IPaging? paging = default, CancellationToken cancellationToken = default);
}
