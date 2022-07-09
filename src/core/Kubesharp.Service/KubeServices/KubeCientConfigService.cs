using Kubesharp.Kube.Abstractions.Interfaces;

namespace Kubesharp.Service.KubeServices;

internal class KubeCientConfigService : IKubeCientConfigService
{
    private readonly IKubeConfig _kubeConfig;

    public KubeCientConfigService(IKubeConfig kubeConfig)
    {
        _kubeConfig = kubeConfig;
    }

    public async Task<KubeConfig> GetFromStreamAsync(
        Stream stream, CancellationToken cancellationToken)
    {
        var kubeConfig = await _kubeConfig.GetFromStreamAsync(stream, cancellationToken);

        throw new NotImplementedException();
    }

    public Task<KubeConfig> GetAsync(
        string userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
