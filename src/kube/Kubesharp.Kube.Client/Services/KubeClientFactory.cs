using System.Collections.Concurrent;

using Kubesharp.Kube.Client.Extensions;

namespace Kubesharp.Kube.Client.Services;

public class KubeClientFactory : IKubeClientFactory
{
    private readonly ConcurrentDictionary<KubeConnectionOptions, Task<KubeClient>>
        _clients = new(KubeConnectionComparer.Instance);

    public async Task<IKubeClient> CreateOrGetKubeClientAsync(
        KubeConnectionOptions config, Func<KubeConnectionOptions, KubeConnectionOptions> configFileFunc)
    {
        return await _clients.GetOrAdd(config, p =>
        {
            var options = configFileFunc?.Invoke(p);

            var config = K8sConfigBuilder.Build(options);

            return Task.FromResult(new KubeClient(new(config)));
        });
    }

    public async Task<IKubeClient> CreateOrGetKubeClientAsync(
        KubeConnectionOptions config, Func<KubeConnectionOptions, Stream> configFileFunc)
    {
        return await _clients.GetOrAdd(config, async p =>
        {
            var stream = configFileFunc(p);

            var config =
                await KubernetesClientConfiguration.BuildConfigFromConfigFileAsync(stream);

            return new KubeClient(new(config));
        });
    }

    public bool Disconnect(KubeConnectionOptions config)
    {
        _clients.TryRemove(config, out var _);

        return Task.FromResult();
    }
}
