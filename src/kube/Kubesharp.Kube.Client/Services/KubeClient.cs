using System.Diagnostics.CodeAnalysis;

using Kubesharp.Kube.Client.Api;

namespace Kubesharp.Kube.Client.Services;

public class KubeClient : IKubeClient, IDisposable
{
    private readonly SemaphoreSlim _semaphore = new(1);

    public KubeClient(Kubernetes kube)
    {
        this.K8sClient = kube;

        this.NamespaceApi = new KubeNamespaceApi(kube);
    }

    public Kubernetes K8sClient { get; }

    public IKubeNamespaceApi NamespaceApi { get; private set; }

    public void Dispose()
    {
        this.K8sClient.Dispose();

        this.NamespaceApi = null!;
        // TODO
    }
}
