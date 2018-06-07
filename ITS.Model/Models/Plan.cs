using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{

    class Plan
    {
        [Key]
        public int ID { get; set; }

        IEnumerable<PlanDetail> PlanDetails { get; set; }
    }
}
