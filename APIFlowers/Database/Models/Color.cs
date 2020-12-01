﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIFlowers.Database.Models
{
    [Table("Color")]
    public class Color
    {
        [Key, Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}