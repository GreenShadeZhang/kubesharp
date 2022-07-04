namespace Kubesharp.Kube.Abstractions.ClientApi;

public interface IKubeClient
{
    IKubeNamespaceApi NamespaceApi { get; }
}
