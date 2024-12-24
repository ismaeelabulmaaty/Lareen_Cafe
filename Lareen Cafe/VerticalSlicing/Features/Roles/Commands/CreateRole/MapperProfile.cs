using AutoMapper;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.CreateRole.CreateNewRole;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles.Commands.CreateRole
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AddRoleRequest, CreateRoleCommand>();

            CreateMap<CreateRoleCommand, Role>()
                 .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.roleName));
        }

    }
}
