using Kubesharp.Kube.Abstractions.ClientApi;

namespace Kubesharp.Kube.Abstractions.Interfaces;

public interface IKubeClient
{
    IKubeNamespaceApi NamespaceApi { get; }
}
