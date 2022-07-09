namespace Kubesharp.Kube.Client.Api;

internal class KubePodApi : IKubePodApi
{
    private readonly Kubernetes _kubeClient;

    public KubePodApi(Kubernetes kubeClient)
    {
        _kubeClient = kubeClient;
    }

    public Task<PodDto> CreateAsync(PodDto model, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(string name, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<PodDto> UpdateAsync(PodDto model, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<PodDto> GetAsync(string Name, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<List<PodDto>> ListAsync(string @namespace, CancellationToken cancellationToken)
    {
        var list = await _kubeClient
            .ListNamespacedPodAsync(@namespace, cancellationToken: cancellationToken);

        return list.ToDtoList();
    }
}
