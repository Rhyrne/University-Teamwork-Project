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

            CreateMap<Role,RoleDTO>();
            CreateMap<RoleDTO,Role>();

            CreateMap<New,NewsDTO>();
            CreateMap<NewsDTO,New>();

            CreateMap<Job, JobDTO>();
            CreateMap<JobDTO, Job>();

            CreateMap<Feedback, FeedbackDTO>();
            CreateMap<FeedbackDTO, Feedback>();

            CreateMap<Business, BusinessDTO>();
            CreateMap<BusinessDTO, Business>();
        }
    }
}
