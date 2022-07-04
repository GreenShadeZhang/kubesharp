namespace Kubesharp.Kube.Abstractions.ClientApi;

public interface IKubeClient
{
    IKubeNamespaceServcie NamespaceApi { get; set; }
}
