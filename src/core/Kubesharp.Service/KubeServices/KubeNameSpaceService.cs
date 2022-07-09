using Kubesharp.Kube.Abstractions.Interfaces;

namespace Kubesharp.Service.KubeServices;

internal class KubeNamespaceService : IKubeNamespaceService
{
    private readonly IKubeClient _kubeClient;
    private readonly IKubeNamespaceApi _namespaceApi;

    public KubeNamespaceService(IKubeClient kubeClient)
    {
        _kubeClient = kubeClient;
        _namespaceApi = _kubeClient.NamespaceApi;
    }

    public async Task<IEnumerable<Namespace>> ListAsync(
        CancellationToken cancellationToken)
    {
        var namespaces = await _namespaceApi.ListAsync(cancellationToken);

        return namespaces.Select(n => n.ToDomain());
    }

    public async Task<Namespace> GetAsync(
        string name, CancellationToken cancellationToken)
    {
        var @namespace = await _namespaceApi.GetAsync(name, cancellationToken);

        return @namespace.ToDomain();
    }
}
