using AutoMapper;
using static Lareen_Cafe.VerticalSlicing.Features.Account.Login.Commands.LoginUserCommand;

namespace Lareen_Cafe.VerticalSlicing.Features.Account.Login
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<LoginRequest, LoginCommand>();
        }
    }
}
