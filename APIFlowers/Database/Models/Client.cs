using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("Cell")]
    public class Client
    {
        [Key, Phone, Required]
        public int Phone { get; set; }

        [MaxLength(150), MinLength(3), Required]
        public string FullName { get; set; }
        
        public bool Permanent { get; set; }


        
    }
}
