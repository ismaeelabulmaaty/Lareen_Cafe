using Lareen_Cafe.VerticalSlicing.Common;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using LareenCafe.Api.VerticalSlicing.Common;
using MediatR;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Queries.GetRoleByName
{
    public record GetRoleByNameQuery(string Name) : IRequest<Result<Role>>;
    public class GetRoleByNameQueryHandler : BaseRequestHandler<GetRoleByNameQuery, Result<Role>>
    {
        public GetRoleByNameQueryHandler(RequestParameters requestParameters) : base(requestParameters) { }
        public override async Task<Result<Role>> Handle(GetRoleByNameQuery request, CancellationToken cancellationToken)
        {
            var role = (await _unitOfWork.Repository<Role>().GetAsync(u => u.Name == request.Name)).FirstOrDefault();
            if (role == null)
            {
                return null;
            }

            return Result.Success(role);
        }
    }
}
