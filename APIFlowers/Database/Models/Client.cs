using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("Client")]
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None), Phone]
        public ulong Phone { get; set; }

        [MaxLength(150), MinLength(3), Required]
        public string FullName { get; set; }
        
        public bool Permanent { get; set; }
        [Required]
        public string HashPassword { get; set; }


    }
}
