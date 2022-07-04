using Kubesharp.Kube.Abstractions.Models;

namespace Kubesharp.Kube.Abstractions.ClientApi;

public interface IKubeNamespaceApi : IKubeApi
{
    Task<NamespaceDto> CreateAsync(NamespaceDto model, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(string name, CancellationToken cancellationToken);
    Task<NamespaceDto> UpdateNamespaceAsync(NamespaceDto model, CancellationToken cancellationToken);
    Task<NamespaceDto> GetAsync(string Name, CancellationToken cancellationToken);
    Task<List<NamespaceDto>> ListAsync(CancellationToken cancellationToken);
}
