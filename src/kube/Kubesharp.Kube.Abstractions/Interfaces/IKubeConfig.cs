using Kubesharp.Kube.Abstractions.Models;

namespace Kubesharp.Kube.Abstractions.Interfaces;

public interface IKubeConfig
{
    Task<KubeConfigDto> GetFromStreamAsync(Stream stream, CancellationToken cancellation);
}
