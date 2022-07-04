using k8s;

using Kubesharp.Kube.Client.Api;

namespace Kubesharp.Kube.Client.Impl;

public class KubeClient : IKubeClient
{
    private readonly SemaphoreSlim _semaphore = new(1);

    public KubeClient(Kubernetes kube)
    {
        this.K8sClient = kube;

        this.NamespaceApi = new KubeNamespaceApi(kube);
    }

    public Kubernetes K8sClient { get; }

    public IKubeNamespaceApi NamespaceApi { get; }
}
