using System;
namespace Kubesharp.Core.Aggregate;

/// <summary>
/// 集群用户
/// </summary>
public class ClientUser : EntityBase, IAggregateRoot
{
    #region Property
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
    #endregion

    #region Action
    public void Update(
        string? name,
        string certificate,
        string? key)
    {
        if (name is not null)
        {
            this.Name = name;
        }

        if (certificate is not null)
        {
            this.Certificate = certificate;
        }

        if (key is not null)
        {
            this.Key = key;
        }
    }
    #endregion
}
