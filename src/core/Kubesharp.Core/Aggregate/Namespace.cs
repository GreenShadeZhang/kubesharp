namespace Kubesharp.Core.Aggregate;

public class Namespace : IAggregateRoot
{
    #region Property
    public string Name { get; set; } = String.Empty;

    #endregion

    #region Action
    public void UpdateName(string newName)
    {
        // TODO 校验

        this.Name = newName;
    }

    #endregion
}
