namespace Kubesharp.Kube.Config.Models;

/// <summary>
/// 用户客户端
/// </summary>
public class User
{
    /// <summary>
    /// 客户端名称
    /// </summary>
    public string Name { get; set; } = String.Empty;
    /// <summary>
    /// 客户端秘钥
    /// </summary>
    public string ClientKey { get; set; } = String.Empty;
    /// <summary>
    /// 客户端证书
    /// </summary>
    public string ClientCertificate { get; set; } = String.Empty;
}

