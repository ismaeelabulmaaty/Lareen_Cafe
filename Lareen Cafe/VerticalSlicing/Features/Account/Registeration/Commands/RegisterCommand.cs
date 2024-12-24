using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Account.Registeration.Queries;
using Lareen_Cafe.VerticalSlicing.Features.FeaturesCommon.Helper;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Registeration.Commands
{
    public record RegisterCommand(string UserName, string Email, string Password) : IRequest<Result>;

    public class RegisterCommandHandler : BaseRequestHandler<RegisterCommand, Result>
    {
        public RegisterCommandHandler(RequestParameters requestParameters) : base(requestParameters) { }
        public override async Task<Result> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var userExists = await _mediator.Send(new CheckUserExistsQuery(request.UserName, request.Email));

            if (userExists.Data)
            {
                return Result.Failure<bool>(UserErrors.UserAlreadyExists);
            }

            var user = request.Map<User>();

            user.PasswordHash = PasswordHasher.HashPassword(request.Password);

            var userRepo = _unitOfWork.Repository<User>();

            await userRepo.AddAsync(user);
            await userRepo.SaveChangesAsync();

            return Result.Success();

        }
    }
}
