using System;
namespace Kubesharp.Api.Extensions.ViewModel;

internal static class NamespaceDtoExtensions
{
    public static NamespaceDto ToDto(this Namespace @namespace)
    {
        return new NamespaceDto()
        {
            Name = @namespace.Name,
        };
    }
}
