namespace Kubesharp.Core.Aggregate;

[Table(nameof(KubeConfig), Schema = "sc_Kube")]
public class KubeConfig : EntityBase, IAggregateRoot
{
    #region Property
    [Required]
    public string UserId { get; set; } = String.Empty;

    public string? CurrectCluster { get; set; }

    public ICollection<Cluster> Clusters { get; set; } = new List<Cluster>();

    #endregion

    #region Action
    public void AddCluster(Cluster cluster)
    {
        this.Clusters.Add(cluster);
    }

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

    public bool DeleteCluster(Cluster cluster)
    {
        return this.Clusters.Remove(cluster);
    }
    #endregion
}

