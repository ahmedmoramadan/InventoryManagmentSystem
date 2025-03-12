using DAL;
using DAL.Models;

namespace BLL
{
    public class StockService
    {
        private readonly InventoryDbContext _context;
        public StockService()
        {
            _context = new InventoryDbContext();
        }

        public List<Stock> GetAll()
        {
            return _context.Stocks.ToList();
        }
        public List<Stock> SearchStocks(string type, int? productId)
        {
            var query = _context.Stocks.AsQueryable();

            if(!string.IsNullOrEmpty(type))
            {
                query = query.Where(s => s.Type == type);
            }
            if(productId != null)
            {
                query = query.Where(s => s.ProductId == productId);
            }

            return query.ToList();
        }
    }
}
