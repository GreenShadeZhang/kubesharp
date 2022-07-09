using System.Collections.Concurrent;

namespace Kubesharp.Kube.Client.Impl;

public class KubeClientFactory : IKubeClientFactory
{
    private readonly ConcurrentDictionary<string, Task<KubeClient>> _clients = new();

    public async Task<IKubeClient> CreateOrGetKubeClientAsync(string userId, Func<string, Stream> configFileFunc)
    {
        return await _clients.GetOrAdd(userId, async p =>
        {
            using var stream = configFileFunc(p);

            var config = await KubernetesClientConfiguration.BuildConfigFromConfigFileAsync(stream);

            return new KubeClient(new(config));
        });
    }
}
