using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Cust_Name { get; set; } = string.Empty;
        public decimal Total_Price { get; set; }

        public virtual List<SalesDetails> SalesDetails { get; set; } = new List<SalesDetails>();
    }
}
