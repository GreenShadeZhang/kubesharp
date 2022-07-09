namespace Kubesharp.Core.Aggregate;

[Table(nameof(KubeConfig), Schema = "sc_Kube")]
public class KubeConfig : EntityBase, IAggregateRoot
{
    #region Property
    /// <summary>
    /// 用户编号
    /// </summary>
    [Required]
    public string UserId { get; set; } = String.Empty;

    /// <summary>
    /// 当前选择集群
    /// </summary>
    public Cluster? CurrectCluster { get; set; }
    /// <summary>
    /// 集群连接配置
    /// </summary>
    public ICollection<Cluster> Clusters { get; set; } = new List<Cluster>();

    #endregion

    #region Action
    /// <summary>
    /// 添加集群配置
    /// </summary>
    /// <param name="cluster"></param>
    public void AddCluster(Cluster cluster)
    {
        this.Clusters.Add(cluster);
    }

    /// <summary>
    /// 删除集群配置
    /// </summary>
    /// <param name="clusterName"></param>
    /// <returns></returns>
    public bool DeleteCluster(string clusterName)
    {
        var deleteCluster = this.Clusters.FirstOrDefault(
            c => c.Name == clusterName);

        if (deleteCluster is null)
        {
            return false;
        }

        return this.Clusters.Remove(deleteCluster);
    }

    /// <summary>
    /// 删除集群配置
    /// </summary>
    /// <param name="cluster"></param>
    /// <returns></returns>
    public bool DeleteCluster(Cluster cluster)
    {
        return this.Clusters.Remove(cluster);
    }

    public void SetCurrectCluster(Cluster cluster)
    {
        this.CurrectCluster = cluster;
    }
    #endregion
}

