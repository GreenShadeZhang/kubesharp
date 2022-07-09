namespace Kubesharp.Kube.Abstractions.ClientApi;

public interface IKubeClientFactory
{
    Task<IKubeClient> CreateOrGetKubeClientAsync(string userId, Func<string, Stream> configFileFunc);
}
