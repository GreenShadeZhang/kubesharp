using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kubesharp.Abstractions;

public abstract class EntityBase
{
    /// <summary>
    /// 主键
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 修改用户
    /// </summary>
    [Required]
    public string CreaterId { get; set; } = String.Empty;
    /// <summary>
    /// 修改时间
    /// </summary>
    [Required]
    public DateTimeOffset CreatedTime { get; set; }
    /// <summary>
    /// 修改用户
    /// </summary>
    [Required]
    public string ModifierId { get; set; } = String.Empty;
    /// <summary>
    /// 修改时间
    /// </summary>
    [Required]
    public DateTimeOffset ModifiedTime { get; set; }

    /// <summary>
    /// 是否已被删除
    /// </summary>
    [Required]
    public bool IsDeleted { get; set; }

    private readonly List<DomainEventBase> _domainEvents = new();
    [NotMapped]
    public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

    protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
    internal void ClearDomainEvents() => _domainEvents.Clear();
}

