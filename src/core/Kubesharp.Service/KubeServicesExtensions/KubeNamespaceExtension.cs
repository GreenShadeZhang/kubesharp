namespace Kubesharp.Service.KubeServicesExtensions;

internal static class KubeNamespaceExtensions
{
    public static Namespace ToDomain(this NamespaceDto namespaceDto)
    {
        return new Namespace()
        {
            Name = namespaceDto.Name,
        };
    }
}
