using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{   
    [Table("Flower")]
    public class Flower
    {
        [Key, Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("FlowerKind"), Required]
        public int FlowerKindId { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        //[ForeignKey("WinterHardiness")]
        //public int WinterHardinessId { get; set; }
        [ForeignKey("Aroma")]
        public int AromaId { get; set; }
        public decimal BasicPrice { get; set; }
        public string PhotoPath { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public virtual ICollection<BouquetFlower> BouquetFlowers { get; set; }
        [JsonIgnore]
        public virtual ICollection<FlowerBalance> FlowerBalances { get; set; }
        [JsonIgnore]
        public virtual ICollection<FlowerAreaFlower> FlowerAreaFlowers { get; set; }
        [JsonIgnore]
        public virtual ICollection<RevisionFlower> RevisionFlowers { get; set; }

    }
}
