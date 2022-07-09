namespace Kubesharp.Core.IKubeServics;

public interface IKubeCientConfigService
{
    Task<KubeConfig> GetAsync(string userId, CancellationToken cancellationToken);
    Task<KubeConfig> GetFromStreamAsync(Stream stream, CancellationToken cancellationToken);
}
