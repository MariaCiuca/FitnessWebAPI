using AutoMapper;

namespace FitnessWebAPI.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Entities.User, ExternalModels.UserDTO>();
            CreateMap<ExternalModels.UserDTO, Entities.User>();
        }
    }
}