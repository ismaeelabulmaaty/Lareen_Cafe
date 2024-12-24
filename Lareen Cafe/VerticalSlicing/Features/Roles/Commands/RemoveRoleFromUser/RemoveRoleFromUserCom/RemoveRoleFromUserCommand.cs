using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Account;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Queries.GetRoleById;
using Lareen_Cafe.VerticalSlicing.Features.Users.GetUserById.Query;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRoleFromUser.RemoveRoleFromUserCom
{
    public record RemoveRoleFromUserCommand(int UserRoleId): IRequest<Result<bool>>;
  
    
    public class RemoveRoleFromUserCommandHandler : BaseRequestHandler<RemoveRoleFromUserCommand, Result<bool>>
    {
        
        public RemoveRoleFromUserCommandHandler(RequestParameters requestParameters) : base(requestParameters){}

        public override async Task<Result<bool>> Handle(RemoveRoleFromUserCommand request, CancellationToken cancellationToken)
        {
            //var roleResult = await _mediator.Send(new GetRoleByIdQuery(request.RoleId));
            //if (!roleResult.IsSuccess)
            //{
            //    return Result.Failure<bool>(RoleErrors.RoleNotFound);
            //}
            //var role = roleResult.Data;

            //var userResult = await _mediator.Send(new GetUserByIdQuery(request.UserId));
            //if (!userResult.IsSuccess)
            //{
            //    return Result.Failure<bool>(UserErrors.UserNotFound);
            //}
            //var user = userResult.Data;


            var userRole = await _unitOfWork.Repository<UserRole>()
                .GetByIdAsync(request.UserRoleId);

            if (userRole == null)
            {
                return Result.Failure<bool>(RoleErrors.RoleNotAssigned);
            }

            _unitOfWork.Repository<UserRole>().Delete(userRole);
            await _unitOfWork.SaveChangesAsync();

            return Result.Success(true);
        }
    }
}
