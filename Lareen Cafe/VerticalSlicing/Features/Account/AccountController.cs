using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Features.Account.Login;
using Lareen_Cafe.VerticalSlicing.Features.Account.Registeration;
using Lareen_Cafe.VerticalSlicing.Features.Account.Registeration.Commands;
using LareenCafe.Api.VerticalSlicing.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Lareen_Cafe.VerticalSlicing.Features.Account.Login.Commands.LoginUserCommand;

namespace Lareen_Cafe.VerticalSlicing.Features.Account
{

    public class AccountController : BaseController
    {
        public AccountController(ControllerParameters controllerParameters) : base(controllerParameters) { }


        [HttpPost("Register")]
        public async Task<Result> Register(RegisterRequest viewModel)
        {
            var command = viewModel.Map<RegisterCommand>();
            var result = await _mediator.Send(command);
            return result;

        }

        [HttpPost("Login")]
        public async Task<Result<LoginResponse>> Login(LoginRequest request)
        {
            var command = request.Map<LoginCommand>();
            var result = await _mediator.Send(command);          
            return result;

        }

    }
}
