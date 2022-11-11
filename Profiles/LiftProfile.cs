using AutoMapper;

namespace project_backend.Profiles
{
    public class LiftProfile : Profile
    {
        public LiftProfile()
        {
            CreateMap<Entities.Lift, Models.Lift>();
            CreateMap<Models.LiftCreation, Entities.Lift>();
            CreateMap<Models.LiftUpdate, Entities.Lift>();
        }
    }
}