namespace Kubesharp.Kube.Config.Models;

/// <summary>
/// 上下文
/// </summary>
public class Context
{
    /// <summary>
    /// 上下文名称
    /// </summary>
    public string Name { get; set; } = String.Empty;
    /// <summary>
    /// 集群名称
    /// </summary>
    public string ClusterName { get; set; } = String.Empty;
    /// <summary>
    /// 
    /// </summary>
    public string UserName { get; set; } = String.Empty;
}
