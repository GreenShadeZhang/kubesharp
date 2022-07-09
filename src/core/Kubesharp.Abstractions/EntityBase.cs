using System.ComponentModel.DataAnnotations.Schema;

namespace Kubesharp.Abstractions;

public abstract class EntityBase
{
    public int Id { get; set; }

    private readonly List<DomainEventBase> _domainEvents = new();
    [NotMapped]
    public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

    protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
    internal void ClearDomainEvents() => _domainEvents.Clear();
}

