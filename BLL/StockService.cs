using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    class StockService
    {
        private readonly InventoryDbContext _context;
        StockService()
        {
            _context = new InventoryDbContext();
        }

        public List<Stock> GetAll()
        {
            return _context.Stocks.ToList();
        }
    }
}
