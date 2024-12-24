using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Account.Common.Helper;
using Lareen_Cafe.VerticalSlicing.Features.FeaturesCommon.Helper;
using Lareen_Cafe.VerticalSlicing.Features.Users.GetUserByEmail.Query;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Login.Commands
{
    public class LoginUserCommand
    {
        public record LoginCommand(string Email, string Password) : IRequest<Result<LoginResponse>>;

        public class LoginCommandHandler : BaseRequestHandler<LoginCommand, Result<LoginResponse>>
        {
            public LoginCommandHandler(RequestParameters requestParameters) : base(requestParameters) { }

            public override async Task<Result<LoginResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
            {
                if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
                {
                    return Result.Failure<LoginResponse>(UserErrors.InvalidCredentials);
                }

                var userResult = await _mediator.Send(new GetUserByEmailQuery(request.Email));

                if (!userResult.IsSuccess)
                {
                    return Result.Failure<LoginResponse>(UserErrors.InvalidCredentials);
                }

                var user = userResult.Data;
                if (!PasswordHasher.checkPassword(request.Password , user.PasswordHash))
                {
                    return Result.Failure<LoginResponse>(UserErrors.InvalidCredentials);
                }

                var token = TokenGenerator.GenerateToken(user);

                var loginResponse = new LoginResponse()
                {
                    Id = user.Id,
                    Email = user.Email,
                    Token = token,
                };
                return Result.Success(loginResponse);
            }
        }
    }
}
