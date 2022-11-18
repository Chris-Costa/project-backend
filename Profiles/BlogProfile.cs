using AutoMapper;

namespace project_backend.Profiles
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<Entities.Blog, Models.Blog>();
        }
    }
}