using LareenCafe.Api.VerticalSlicing.Data.Repository.Interface;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Common
{
    public class RequestParameters
    {
        public IMediator Mediator { get; set; }
        public IUnitOfWork UnitOfWork { get; set; }

        public RequestParameters(IMediator mediator, IUnitOfWork unitOfWork)
        {
            Mediator = mediator;
            UnitOfWork = unitOfWork;
        }
    }
}
