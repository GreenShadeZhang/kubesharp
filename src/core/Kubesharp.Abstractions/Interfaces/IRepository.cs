namespace Kubesharp.Abstractions.Interfaces;

internal interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
