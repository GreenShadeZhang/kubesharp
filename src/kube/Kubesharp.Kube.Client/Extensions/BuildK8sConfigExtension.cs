namespace Kubesharp.Kube.Client.Extensions;

public static class K8sConfigBuilder
{
    public static KubernetesClientConfiguration Build(KubeConnectionOptions options)
    {

        return new()
        {
            Host = options.ClusterServerUrl,
            ClientCertificateData = options.ClientCertificate,
            ClientCertificateKeyData = options.ClientKey,
            
            SkipTlsVerify = options.SkipTlsVerify,
        };

        throw new NotImplementedException();
    }
}
