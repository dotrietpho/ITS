using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{
    [Table("LocationTags")]
    public class LocationTag
    {
        [Key]
        [Column(Order =1)]
        public int LocationID { set; get; }

        [Key]
        [MaxLength(50)]
        [Column(Order = 2)]
        public string TagID { get; set; }

        [ForeignKey("LocationID")]
        public virtual Location Location { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
