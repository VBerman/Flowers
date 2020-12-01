using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace APIFlowers.Database.Models
{
    [Table("OrderService")]
    public class OrderService
    {
        [Key, ForeignKey("Order")]
        public int OrderId { get; set; }
        [Key, ForeignKey("Service")]
        public int ServiceId { get; set; }

        public int Amount { get; set; }
        public decimal Price { get; set; }


    }
}
