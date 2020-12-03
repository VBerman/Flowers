using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("Aroma")]
    public class Aroma
    {
        public Aroma()
        {
            FlowerAroma = new HashSet<Flower>();
        }
        [Key, Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public virtual ICollection<Flower> FlowerAroma { get; set; }
    }
}

