using AutoMapper;

namespace project_backend.Profiles
{
    public class WorkoutProfile : Profile
    {
        public WorkoutProfile()
        {
            CreateMap<Entities.Workout, Models.Workout>();
            CreateMap<Models.WorkoutCreation, Entities.Workout>();
        }
    }
}