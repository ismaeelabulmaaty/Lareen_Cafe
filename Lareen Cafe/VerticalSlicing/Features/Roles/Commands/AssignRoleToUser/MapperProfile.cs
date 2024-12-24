using AutoMapper;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.AssignRoleToUser.AssignRoleToUserCom;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.AssignRoleToUser
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AssignRoleToUserRequest, AssignUserToRoleCommand>();
        }
    }
}
