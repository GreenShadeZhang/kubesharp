namespace Kubesharp.Abstractions.Interfaces;

internal interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
