namespace Kubesharp.Kube.Abstractions.Interfaces;

public interface IKubeClientFactory
{
    Task<IKubeClient> CreateOrGetKubeClientAsync(string userId, Func<string, Stream> configFileFunc);
}
