using AutoMapper;

namespace project_backend.Profiles
{
    public class ContactUsProfile : Profile
    {
        public ContactUsProfile()
        {
            CreateMap<Entities.ContactUs, Models.ContactUs>();
            CreateMap<Models.ContactUsCreation, Entities.ContactUs>();
        }
    }
}