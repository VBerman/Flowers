using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("Bouquet")]
    public class Bouquet
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
        
        [JsonIgnore]
        public virtual ICollection<BouquetFlower> BouquetFlowers { get; set; }
    }
}
