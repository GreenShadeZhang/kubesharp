using Kubesharp.Kube.Abstractions.Models;

namespace Kubesharp.Kube.Abstractions.ClientApi;

public interface IKubePodApi : IKubeApi
{
    Task<PodDto> CreateAsync(PodDto model, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(string name, CancellationToken cancellationToken);
    Task<PodDto> UpdateAsync(PodDto model, CancellationToken cancellationToken);
    Task<PodDto> GetAsync(string Name, CancellationToken cancellationToken);
    Task<List<PodDto>> ListAsync(string @namepspace, CancellationToken cancellationToken);

}
