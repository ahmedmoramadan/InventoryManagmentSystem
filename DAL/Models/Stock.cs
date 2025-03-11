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
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        [MaxLength(30)]
        public string Type { get; set; } = string.Empty; //Supply - Sale 
        
        public DateTime LastUpdate { get; set; }

        public int ProductId { get; set; }

        public override string ToString()
        {
            return $"{Quantity}";
        }

    }
}
