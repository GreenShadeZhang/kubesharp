namespace Kubesharp.Core.Aggregate;

/// <summary>
/// 集群用户
/// </summary>
public class ClientUser : EntityBase, IAggregateRoot
{
    /// <summary>
    /// 集群用户名称
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// 集群用户证书
    /// </summary>
    public string Certificate { get; set; } = String.Empty;

    /// <summary>
    /// 集群用户秘钥
    /// </summary>
    public string Key { get; set; } = String.Empty;
}
