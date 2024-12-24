using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Registeration.Queries
{
    public record CheckUserExistsQuery(string UserName, string Email) : IRequest<Result<bool>>;

    public class CheckUserExistsQueryHandler : BaseRequestHandler<CheckUserExistsQuery, Result<bool>>
    {
        public CheckUserExistsQueryHandler(RequestParameters requestParameters) : base(requestParameters) { }
        public override async Task<Result<bool>> Handle(CheckUserExistsQuery request, CancellationToken cancellationToken)
        {
            var existingUser = await _unitOfWork.Repository<User>()
                            .GetAsync(user => user.Email == request.Email || user.UserName == request.UserName);

            return Result.Success(existingUser.Any());
        }
    }
}
