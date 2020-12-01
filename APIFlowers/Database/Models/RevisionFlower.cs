using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("RevisionFlower")]
    public class RevisionFlower
    {
        
        [Key, Required]
        public int RevisionId { get; set; }
        
        [Required]
        public int Amount { get; set; }

        public string Comment { get; set; }
  

    }
}
