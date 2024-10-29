using AutoMapper;
using MODMAPI.DTOs;
using MODMAPI.Models;

namespace MODMAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<User,UserDTO>();
            CreateMap<UserDTO,User>();
        }
    }
}
