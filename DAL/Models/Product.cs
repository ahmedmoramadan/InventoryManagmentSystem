using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ProductSupplier> ProductSuppliers { get; set; } = new List<ProductSupplier>();
        public virtual List<Stock> Stocks { get; set; } = new List<Stock>();
        public virtual List<SalesDetails> SalesDetails { get; set; } = new List<SalesDetails>();
    }
}
