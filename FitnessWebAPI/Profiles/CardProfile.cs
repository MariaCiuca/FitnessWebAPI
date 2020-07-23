using AutoMapper;

namespace FitnessWebAPI.Profiles
{
    public class CardProfile : Profile
    {
        public CardProfile()
        {
            CreateMap<Entities.Valability, ExternalModels.ValabilityDTO>();
            CreateMap<ExternalModels.ValabilityDTO, Entities.Valability>();

            CreateMap<Entities.Card, ExternalModels.CardDTO>();
            CreateMap<ExternalModels.CardDTO, Entities.Card>();
        }
    }
}