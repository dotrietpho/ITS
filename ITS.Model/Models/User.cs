﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        [MaxLength(50)]
        public string Content { get; set; }

        [Required]
        public bool Status { get; set; }
        IEnumerable<Trip> Trips { get; set; }
        IEnumerable<Plan> Plans { get; set; }
    }
}
