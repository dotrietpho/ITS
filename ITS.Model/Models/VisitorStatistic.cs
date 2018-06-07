using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{
    class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public DateTime VisitedDate { get; set; }
    }
}
