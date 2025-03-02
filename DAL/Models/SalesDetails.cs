using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class SalesDetails
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Sale Sale { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

    }
}
