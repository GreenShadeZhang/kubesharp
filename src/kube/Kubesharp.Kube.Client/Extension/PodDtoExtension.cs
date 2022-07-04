namespace Kubesharp.Kube.Client.Extension;

internal static class PodDtoExtension
{
    public static List<PodDto> ToDtoList(this V1PodList namespaces)
    {
        var list = new List<PodDto>();

        foreach (var item in namespaces.Items)
        {
            list.Add(item.ToDto());
        }

        return list;
    }

    static PodDto ToDto(this V1Pod pod)
    {
        return new()
        {
            Name = pod.Name()
        };
    }
}
