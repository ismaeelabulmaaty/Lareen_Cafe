using LareenCafe.Api.VerticalSlicing.Data.Repository.Interface;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Common
{
    public abstract class BaseRequestHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        protected readonly IMediator _mediator;
        protected readonly IUnitOfWork _unitOfWork;


        public BaseRequestHandler(RequestParameters requestParameters)
        {
            _mediator = requestParameters.Mediator;
            _unitOfWork = requestParameters.UnitOfWork;
        }
        public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);

    }
}
