using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Model.Models
{
    [Table("LocationCategorys")]
    public class LocationCategory
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }
        public bool? Status { get; set; }
        public int CityID { get; set; }
        [ForeignKey("CityCategoryID")]
        public virtual CityCategory CityCategory { get; set; }

        public virtual IEnumerable<Location> Locations { set; get; }
    }
}
