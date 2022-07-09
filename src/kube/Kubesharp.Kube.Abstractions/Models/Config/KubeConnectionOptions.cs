using System.Diagnostics.CodeAnalysis;

namespace Kubesharp.Kube.Abstractions.Models;

public class KubeConnectionOptions
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
    /// <summary>
    /// 跳过Tls验证
    /// </summary>
    public bool SkipTlsVerify { get; set; }
}

public class KubeConnectionComparer : IEqualityComparer<KubeConnectionOptions>
{
    public static KubeConnectionComparer Instance = new();

    public bool Equals(KubeConnectionOptions? x, KubeConnectionOptions? y)
    {
        if (x is null)
        {
            throw new ArgumentNullException();
        }

        if (String.IsNullOrWhiteSpace(x.ClusterServerUrl))
        {
            throw new ArgumentNullException("ServiceUrl");
        }

        if (y is null)
        {
            return false;
        }

        if (x.ClusterServerUrl == y.ClusterServerUrl
            && x.ClusterCertificate == y.ClusterCertificate
            && x.ClientCertificate == y.ClientCertificate
            && x.ClientKey == y.ClientKey)
        {
            return true;
        }

        return false;
    }

    public int GetHashCode([DisallowNull] KubeConnectionOptions config)
    {
        return HashCode.Combine(
            config.ClusterServerUrl,
            config.ClusterCertificate,
            config.ClientCertificate,
            config.ClientKey);
    }
}