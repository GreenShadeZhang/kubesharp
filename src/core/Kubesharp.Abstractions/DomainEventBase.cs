
using Kubesharp.Modules.MediatR.Interface;

namespace Kubesharp.Abstractions;

public abstract class DomainEventBase : INotification
{
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}