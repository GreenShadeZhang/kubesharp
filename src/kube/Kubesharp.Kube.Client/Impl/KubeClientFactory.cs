using System.Collections.Concurrent;

using k8s;

namespace Kubesharp.Kube.Client.Impl;

public class KubeClientFactory
{
    private readonly ConcurrentDictionary<string, Task<KubeClient>> _clients = new();

    public async Task<KubeClient> CreateOrGetKubeClientAsync(string userId, Func<string, Stream> configFileFunc)
    {
        return await _clients.GetOrAdd(userId, async p =>
        {
            using var stream = configFileFunc(p);

            var config = await KubernetesClientConfiguration.BuildConfigFromConfigFileAsync(stream);

            return new KubeClient(new(config));
        });
    }
}
