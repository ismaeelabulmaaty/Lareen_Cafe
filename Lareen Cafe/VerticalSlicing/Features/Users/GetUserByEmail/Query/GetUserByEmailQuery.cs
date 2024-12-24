using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Account;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Users.GetUserByEmail.Query
{
    public record GetUserByEmailQuery(string Email) : IRequest<Result<User>>;

    public class GetUserByEmailQueryHandler : BaseRequestHandler<GetUserByEmailQuery, Result<User>>
    {

        public GetUserByEmailQueryHandler(RequestParameters requestParameters) : base(requestParameters) { }

        public override async Task<Result<User>> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Email))
            {
                return Result.Failure<User>(UserErrors.InvalidEmail);
            }

            var user = (await _unitOfWork.Repository<User>().GetAsync(u => u.Email == request.Email)).FirstOrDefault();
            if (user == null)
            {
                return Result.Failure<User>(UserErrors.UserNotFound);
            }

            return Result.Success(user);
        }
    }
}
