namespace Kubesharp.Core.Aggregate;

/// <summary>
/// 集群
/// </summary>
public class Cluster : IAggregateRoot
{
    /// <summary>
    /// 集群名称
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// 集群证书
    /// </summary>
    public string Certificate { get; set; } = String.Empty;

    /// <summary>
    /// 集群服务器地址
    /// </summary>
    public string ServerUrl { get; set; } = String.Empty;
}
