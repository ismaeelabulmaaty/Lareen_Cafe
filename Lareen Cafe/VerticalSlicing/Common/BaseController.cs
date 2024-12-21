using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Lareen_Cafe.VerticalSlicing.Common
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly IMediator _mediator;

        public BaseController(ControllerParameters controllerParameters)
        {
            _mediator = controllerParameters.Mediator;

        }
    }
}
