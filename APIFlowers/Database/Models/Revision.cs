using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("Revision")]
    public class Revision
    {
        [Key, Required]
        public int Id { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
