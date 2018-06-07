using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITS.Model.Models
{
    [Table("Locations")]
    class Location
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string Contact { get; set; }
        
        [MaxLength(500)]
        public string IP { get; set; }

        [Required]
        [MaxLength(500)]
        public string Address { get; set; }
        public double Rate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTimeOffset OpenTime { get; set; }
        public DateTimeOffset ClosedTime { get; set; }
        [MaxLength(256)]
        public string URL {get;set;}
        [MaxLength(256)]
        public string Image { get; set; }
        public XElement MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal StartPrice { get; set; }
        [MaxLength(500)]
        public string Detail { get; set; }
        public bool HomeFlag { get; set; }
        public int ViewCount { get; set; }
        public bool Status { get; set; } 
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual LocationCategory LocationCategory { get; set; }

    }
}
