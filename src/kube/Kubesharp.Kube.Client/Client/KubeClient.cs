using k8s;

using Kubesharp.Kube.Client.Api;

namespace Kubesharp.Kube.Api.Client;

public class KubeClient : IKubeClient
{
    public KubeClient(Kubernetes kube)
    {
        this.K8sClient = kube;

        this.NamespaceApi = new KubeNamespaceService(kube);
    }

    protected Kubernetes K8sClient { get; }

    public IKubeNamespaceServcie NamespaceApi { get; set; }
}
