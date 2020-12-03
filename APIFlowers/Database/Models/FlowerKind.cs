using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("FlowerKind")]
    public class FlowerKind
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<Flower> FlowerKinds { get; set; }

    }
}
