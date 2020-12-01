using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIFlowers.Database.Models
{
    [Table("Service")]
    public class Service
    {
        [Key, Required]
        public int Id { get; set; }
        [MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        public decimal BasicPrice { get; set; }

    }
}
