using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("FlowerBalance")]
    public class FlowerBalance
    {
        [Key, Required, ForeignKey("Flower")]
        public int FlowerId { get; set; }
        [Key, Required, DataType(DataType.Date)]
        public DateTime Date {get; set;}

        public int Amount { get; set; }
   

    }
}
