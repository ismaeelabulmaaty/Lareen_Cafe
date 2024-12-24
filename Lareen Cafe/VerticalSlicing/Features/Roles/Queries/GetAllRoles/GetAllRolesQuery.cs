using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Queries.GetAllRoles
{
    public record GetAllRolesQuery() : IRequest<Result<List<Role>>>;
    public class GetAllRolesQueryHandler : BaseRequestHandler<GetAllRolesQuery, Result<List<Role>>>
    {
        public GetAllRolesQueryHandler(RequestParameters requestParameters) : base(requestParameters) { }

        public override async Task<Result<List<Role>>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var roles = await _unitOfWork.Repository<Role>().GetAllAsync();
            return Result.Success(roles.ToList());
        }
    }
}
