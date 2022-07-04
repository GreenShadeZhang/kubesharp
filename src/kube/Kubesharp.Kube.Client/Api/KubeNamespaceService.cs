
using k8s;

namespace Kubesharp.Kube.Client.Api;

internal class KubeNamespaceService : IKubeNamespaceServcie
{
    private readonly Kubernetes _kubeClient;

    public KubeNamespaceService(Kubernetes kubeClient)
    {
        _kubeClient = kubeClient;
    }

    public Task<List<Namespace>> ListNamespaceAsync(CancellationToken cancellationToken)
    {
        //return _kubeClient.ListNamespaceAsync(cancellationToken: cancellationToken);

        throw new NotImplementedException();
    }
}
