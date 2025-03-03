using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
     public class Supplier
     {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(30)]

        public string Contact { get; set; } = string.Empty;
        [MaxLength(100)]

        public string Address { get; set; } = string.Empty;

        public virtual List<Product> Products { get; set; } = new List<Product>();
     }
}
