﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FitnessWebAPI.Entities
{
    public class Valability
    {
        [Key]
        public Guid ID { get; set; }


        [Required]
        public int Day { get; set; }

        [Required]
        public int Month { get; set; }

        [Required]
        public int Year { get; set; }

        public bool? Deleted { get; set; }
    }
}
