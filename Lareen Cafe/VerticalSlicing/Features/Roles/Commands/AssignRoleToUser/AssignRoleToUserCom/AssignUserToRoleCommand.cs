using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Account;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Queries.GetRoleByName;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Queries.GetUserRoleById;
using Lareen_Cafe.VerticalSlicing.Features.Users.GetUserById.Query;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.AssignRoleToUser.AssignRoleToUserCom
{
    public record AssignUserToRoleCommand(int userId, string roleName) : IRequest<Result<bool>>;
    public class AssignUserToRoleCommandHandler : BaseRequestHandler<AssignUserToRoleCommand, Result<bool>>
    {
        public AssignUserToRoleCommandHandler(RequestParameters requestParameters) : base(requestParameters){}

        public override async Task<Result<bool>> Handle(AssignUserToRoleCommand request, CancellationToken cancellationToken)
        {
            var validationResult = await ValidateUserRole(request.userId, request.roleName);

            if (!validationResult.IsSuccess)
            {
                return Result.Failure<bool>(validationResult.Error);
            }
            var role = validationResult.Data;

            var userRole = new UserRole
            {
                UserId = request.userId,
                RoleId = role.Id
            };

            await _unitOfWork.Repository<UserRole>().AddAsync(userRole);
            await _unitOfWork.SaveChangesAsync();

            return Result.Success(true);
        }
        private async Task<Result<Role>> ValidateUserRole(int userId, string roleName)
        {
            var resultuser = await _mediator.Send(new GetUserByIdQuery(userId));
            if (!resultuser.IsSuccess || resultuser.Data == null)
            {
                return Result.Failure<Role>(UserErrors.UserNotFound);
            }

            var roleResult = await _mediator.Send(new GetRoleByNameQuery(roleName));
            if (!roleResult.IsSuccess || roleResult.Data == null)
            {
                return Result.Failure<Role>(RoleErrors.RoleNotFound);
            }
            var role = roleResult.Data;
            var userRolesResult = await _mediator.Send(new GetUserRoleByIdQuery(userId, role.Id));

            if (userRolesResult.IsSuccess)
            {
                return Result.Failure<Role>(RoleErrors.RoleAlreadyExists);
            }
            return Result.Success(role);
        }
    }
}
