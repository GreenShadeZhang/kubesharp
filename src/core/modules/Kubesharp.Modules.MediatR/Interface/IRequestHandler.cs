namespace Kubesharp.Modules.MediatR.Interface;

public interface IRequestHandler<in TRequest, TResponse> : global::MediatR.IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
}
