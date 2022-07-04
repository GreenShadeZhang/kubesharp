using Kubesharp.Kube.Client.Extension;

namespace Kubesharp.Kube.Client.Api;

internal class KubeNamespaceApi : IKubeNamespaceApi
{
    private readonly Kubernetes _kubeClient;

    public KubeNamespaceApi(Kubernetes kubeClient)
    {
        _kubeClient = kubeClient;
    }

    public Task<NamespaceDto> CreateAsync(
        NamespaceDto model, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(
        string name, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<NamespaceDto> GetAsync(
        string Name, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<NamespaceDto>> ListAsync(
        CancellationToken cancellationToken)
    {
        var namespaces = await _kubeClient.ListNamespaceAsync(cancellationToken: cancellationToken);

        return namespaces.ToDtoList();
    }

    public Task<NamespaceDto> UpdateNamespaceAsync(
        NamespaceDto model, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
