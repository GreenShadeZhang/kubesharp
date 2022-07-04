namespace Kubesharp.Modules.MediatR.Interface;

public interface IRequest<out TResponse> : global::MediatR.IRequest<TResponse>
{
}
