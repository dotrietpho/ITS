using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{
    [Table("StopPoints")]
    class StopPoint
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [MaxLength(2000)]
        public string Content { get; set; }

        [Required]
        [MaxLength(2000)]
        public string IP { get; set; }

        public int TripID { get; set; }
        [ForeignKey("TripID")]
        public virtual Trip Trip { get; set; }
        [Required]
        public bool IsFinish { get; set; }
    }
}
