using AutoMapper;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRole;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRoleFromUser.RemoveRoleFromUserCom;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.RemoveRoleFromUser
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RemoveRoleFromUserRequest, RemoveRoleFromUserCommand>();          
        }
    }
    
}
