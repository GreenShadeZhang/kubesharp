using Kubesharp.Kube.Abstractions.Models;

namespace Kubesharp.Kube.Abstractions.Interfaces;

public interface IKubeClientFactory
{
    Task<IKubeClient> CreateOrGetKubeClientAsync(
        KubeConnectionOptions config, Func<KubeConnectionOptions, Stream> configFileFunc);

    Task<IKubeClient> CreateOrGetKubeClientAsync(
        KubeConnectionOptions config, Func<KubeConnectionOptions, KubeConnectionOptions> configFileFunc);

    Task<bool> DisconnectAsync(KubeConnectionOptions config);
}
