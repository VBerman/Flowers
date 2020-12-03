using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("FlowerArea")]
    public class FlowerArea
    {
        [Key, Required]
        public int Id { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<FlowerAreaFlower> FlowerAreaFlowers { get; set; }
    }
}
