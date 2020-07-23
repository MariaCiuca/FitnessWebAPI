using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessWebAPI.Entities
{
    public class Card
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ValabilityID { get; set; }

        [ForeignKey("ValabilityID")]
        public virtual Valability Valability { get; set; }

        public bool? Deleted { get; set; }
    }


}
