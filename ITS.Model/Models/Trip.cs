using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{
    [Table("Trips")]
    public class Trip
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTimeOffset StartDay { get; set; }
        public DateTimeOffset StopDay { get; set; }
        public virtual IEnumerable<StopPoint> StopPoints { get; set; }

        [MaxLength(50)]
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User user { get; set; }
    }
}
