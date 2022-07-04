namespace Kubesharp.Kube.Client.Extension;

internal static class NamespaceDtoExtension
{
    public static List<NamespaceDto> ToDtoList(this V1NamespaceList namespaces)
    {
        var list = new List<NamespaceDto>();

        foreach (var item in namespaces.Items)
        {
            list.Add(item.ToDto());
        }

        return list;
    }

    static NamespaceDto ToDto(this V1Namespace @namespace)
    {
        return new()
        {
            Name = @namespace.Name()
        };
    }
}
