using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRole
{
    public record RemoveRoleCommand(int RoleId) : IRequest<Result<bool>>;
    public class RemoveRoleCommandHandler : BaseRequestHandler<RemoveRoleCommand, Result<bool>>
    {
        public RemoveRoleCommandHandler(RequestParameters requestParameters) : base(requestParameters) { }

        public override async Task<Result<bool>> Handle(RemoveRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await _unitOfWork.Repository<Role>().GetByIdAsync(request.RoleId);
            if (role == null)
            {
                return Result.Failure<bool>(RoleErrors.RoleNotFound);
            }

            _unitOfWork.Repository<Role>().DeleteById(role.Id);
            await _unitOfWork.SaveChangesAsync();

            return Result.Success(true);
        }
    }
}
