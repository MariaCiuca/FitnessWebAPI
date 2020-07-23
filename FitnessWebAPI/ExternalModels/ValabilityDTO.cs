using System;

namespace FitnessWebAPI.ExternalModels
{
    public class ValabilityDTO
    {
        public Guid ID { get; set; }

        public int Day { get; set; }

        public int Month { get; set; }

        public int Year { get; set; }
    }
}