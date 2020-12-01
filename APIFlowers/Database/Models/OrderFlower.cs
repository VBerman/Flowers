using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("OrderFlower")]
    public class OrderFlower
    {
        [Key, ForeignKey("Order")]
        public int OrderId { get; set; }
        [Key, ForeignKey("Flower")]
        public int FlowerId { get; set; }
        [Required]
        public int Amount { get; set; }
    }
}
