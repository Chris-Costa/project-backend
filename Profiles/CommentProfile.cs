using AutoMapper;

namespace project_backend.Profiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Entities.Comment, Models.Comment>();
        }
    }
}