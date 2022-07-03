using System;

using k8s;

namespace Kubesharp.Kube.Api.Client;

public class KubeClient
{
    public KubeClient(Kubernetes kube)
    {
        this.Client = kube;
    }

    public Kubernetes Client { get; }

    public void MyMethod()
    {
        this.Client.
    }
}
