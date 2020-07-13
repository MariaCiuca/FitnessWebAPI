using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessWebAPI.Entities
{
    public class Card
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public Guid ValabilityID { get; set; }

        [ForeignKey("ValabilityId")]
        public virtual Valability Valability { get; set; }

        public bool? Deleted { get; set; }
    }

   
}
