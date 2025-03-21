﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;

        public virtual List<Product> Products { get; set; } = new List<Product>();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
