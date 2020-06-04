using AutoMapper;
using PepeTheDog.Core.Entities.Auth;
using PepeTheDog.Services.Dtos.Auth;

namespace PepeTheDog.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UpdateRolUserDto, AppUser>().ReverseMap();
        }
    }
}
