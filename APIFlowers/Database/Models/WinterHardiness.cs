using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("WinterHardiness")]
    public class WinterHardiness
    {
        public WinterHardiness()
        {
            FlowerWinterHardiness = new HashSet<Flower>();
        }
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [JsonIgnore]
        public virtual ICollection<Flower> FlowerWinterHardiness { get; set; }
    }
}
