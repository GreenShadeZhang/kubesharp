using System;
namespace Kubesharp.Core.Aggregate.Authorization;

internal class User : EntityBase, IAggregateRoot
{
    #region Property
    /// <summary>
    /// 用户名
    /// </summary>
    public string Name { get; set; } = String.Empty;
    /// <summary>
    /// 用户显示名称
    /// </summary>
    public string DisplayName { get; set; } = String.Empty;
    /// <summary>
    /// 密码
    /// </summary>
    public string Password { get; set; } = String.Empty;
    #endregion

    #region Action
    public void Update(object arg)
    {

        throw new NotImplementedException();
    }

    public string SetPassword(string newPassword)
    {
        this.Password = newPassword;
    }
    #endregion
}
