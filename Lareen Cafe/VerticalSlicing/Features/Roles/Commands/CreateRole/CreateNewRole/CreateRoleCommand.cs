using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Queries;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Queries.GetRoleByName;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.CreateRole.CreateNewRole
{
    public record CreateRoleCommand(string roleName) : IRequest<Result<bool>>;
    public class CreateRoleCommandHandler : BaseRequestHandler<CreateRoleCommand, Result<bool>>
    {
        public CreateRoleCommandHandler(RequestParameters requestParameters) : base(requestParameters) { }

        public override async Task<Result<bool>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var roleResult = await _mediator.Send(new GetRoleByNameQuery(request.roleName), cancellationToken);

            if (roleResult is not null)
            {
                return Result.Failure<bool>(RoleErrors.RoleAlreadyExists);
            }
            var role = request.Map<Role>();
            var roleRepo = _unitOfWork.Repository<Role>();
            await roleRepo.AddAsync(role);
            await roleRepo.SaveChangesAsync();

            return Result.Success(true);

        }
    }
}
