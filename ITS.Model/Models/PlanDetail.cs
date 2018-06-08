using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{
    [Table("PlanDetails")]
    public class PlanDetail
    {
        [Key]
        public int PlanID { get; set; }

        [MaxLength(2000)]
        public string Content { get; set; }

        public DateTime CreatedDay { get; set; }

        [Required]
        public DateTime SetDay { get; set; }

        [ForeignKey("PlanID")]
        public virtual Plan Plan { get; set; }

        public IEnumerable<Location> Locations { get; set; }
    }
}
