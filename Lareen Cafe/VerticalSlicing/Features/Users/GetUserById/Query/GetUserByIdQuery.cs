using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Account;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Users.GetUserById.Query
{
    public record GetUserByIdQuery(int UserId) : IRequest<Result<User>>;
    public class GetUserByIdQueryHandler : BaseRequestHandler<GetUserByIdQuery, Result<User>>
    {
        public GetUserByIdQueryHandler(RequestParameters requestParameters) : base(requestParameters) { }

        public override async Task<Result<User>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.Repository<User>().FirstAsync(u => u.Id == request.UserId && !u.IsDeleted);

            if (user == null)
            {
                return Result.Failure<User>(UserErrors.UserNotFound);
            }

            return Result.Success(user);
        }
    }
}
