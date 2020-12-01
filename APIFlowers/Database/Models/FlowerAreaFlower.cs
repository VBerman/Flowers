using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("FlowerAreaFlower")]
    public class FlowerAreaFlower
    {
        [Key, ForeignKey("FlowerArea"), Required]
        public int FlowerAreaId { get; set; }
        [Key, Required]
        public int Row { get; set; }
        [Key, Required]
        public int Column { get; set; }
        [ForeignKey("Flower"), Required]
        public int FlowerId { get; set; }
        public string Description { get; set; }
    }
}
