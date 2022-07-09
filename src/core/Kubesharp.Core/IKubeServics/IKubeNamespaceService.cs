namespace Kubesharp.Core.IKubeServics;

public interface IKubeNamespaceService : IKubeService<Namespace>
{
    Task<Namespace> GetAsync(string name, CancellationToken cancellationToken);
    Task<IEnumerable<Namespace>> ListAsync(CancellationToken cancellationToken);
}
