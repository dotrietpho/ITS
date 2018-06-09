using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{

    public class Plan
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(200)]
        public string Content { get; set; }
        [MaxLength(50)]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User users { get; set; }
        IEnumerable<PlanDetail> PlanDetails { get; set; }
    }
}
