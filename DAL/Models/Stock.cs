using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Stock
    {
        [MaxLength(30)]
        public string Type { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime LastUpdate { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        
    }
}
