namespace Kubesharp.Kube.Abstractions.Models;

public class KubeConfigDto
{
    /// <summary>
    /// 集群名称
    /// </summary>
    public string ClusterName { get; set; } = String.Empty;
    /// <summary>
    /// 集群证书
    /// </summary>
    public string ClusterCertificate { get; set; } = String.Empty;
    /// <summary>
    /// 集群服务器地址
    /// </summary>
    public string ClusterServerUrl { get; set; } = String.Empty;
    /// <summary>
    /// 客户端名称
    /// </summary>
    public string ClientName { get; set; } = String.Empty;
    /// <summary>
    /// 客户端秘钥
    /// </summary>
    public string ClientKey { get; set; } = String.Empty;
    /// <summary>
    /// 客户端证书
    /// </summary>
    public string ClientCertificate { get; set; } = String.Empty;
}
