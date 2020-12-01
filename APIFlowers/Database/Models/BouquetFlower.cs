using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("BouquetFlower")]
    public class BouquetFlower
    {
        [Key, ForeignKey("Bouquet"), Required]
        public int BouquetId { get; set; }
        [Key, ForeignKey("Flower"), Required]
        public int FlowerId { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
