using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("Status")]
    public class Status
    {
        public Status()
        {
            OrderStatus = new HashSet<Order>();
        }
        [Key]
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Order> OrderStatus { get; set; }
    }
}
