using Kubesharp.Kube.Abstractions.Interfaces;
using Kubesharp.Kube.Abstractions.Models;

namespace Kubesharp.Kube.Config.Services;
internal class KubeConfig : IKubeConfig
{
    public Task<KubeConfigDto> GetFromStreamAsync(
        Stream stream, CancellationToken cancellation)
    {
        throw new NotImplementedException();
    }
}
