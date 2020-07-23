using System;

namespace FitnessWebAPI.ExternalModels
{
    public class UserDTO
    {
        public Guid ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool? Deleted { get; set; }
    }
}