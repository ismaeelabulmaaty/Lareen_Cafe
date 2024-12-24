using AutoMapper;
using Lareen_Cafe.VerticalSlicing.Data.Entities;
using Lareen_Cafe.VerticalSlicing.Features.Account.Registeration.Commands;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Registeration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RegisterRequest, RegisterCommand>();
            CreateMap<RegisterCommand, User>();
        }

    }
}
