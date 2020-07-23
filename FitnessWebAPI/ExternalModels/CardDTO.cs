using System;

namespace FitnessWebAPI.ExternalModels
{
    public class CardDTO
    {
        public Guid Id { get; set; }

        public Guid ValabilityID { get; set; }

        public ValabilityDTO Valability { get; set; }
    }
}