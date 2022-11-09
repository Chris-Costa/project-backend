using AutoMapper;

namespace project_backend.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.User, Models.User>();
        }
    }
}