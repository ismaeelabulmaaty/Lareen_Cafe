using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Common
{
    public class ControllerParameters
    {
        public IMediator Mediator { get; set; }
        public ControllerParameters(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
