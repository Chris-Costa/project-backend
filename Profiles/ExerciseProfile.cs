using AutoMapper;

namespace project_backend.Profiles
{
    public class ExerciseProfile : Profile
    {
        public ExerciseProfile()
        {
            CreateMap<Entities.Exercise, Models.Exercise>();
        }
    }
}