using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    class SaleDetaillsService
    {
        private readonly InventoryDbContext _context;
        public SaleDetaillsService(InventoryDbContext context)
        {
            this._context = context;
        }
       
        public async Task<bool> AddSalesDetailsAsync(SalesDetails salesDetails)
        {
            if (salesDetails == null)
            {
                return false;
            }

            var product = await _context.Products.FindAsync(salesDetails.ProductId);
            if (product == null)
            {
                return false; 
            }

            var sale = await _context.Sales.FindAsync(salesDetails.SaleId);
            if (sale == null)
            {
                return false; 
            }

            await _context.SalesDetails.AddAsync(salesDetails);

            sale.Total_Price += salesDetails.Quantity * salesDetails.Price;
            _context.Sales.Update(sale);

            var rowsAffected = await _context.SaveChangesAsync();
            return rowsAffected > 0;
        }
        public async Task<List<SalesDetails>> GetAllSalesDetailsAsync()
        {
            return await _context.SalesDetails
                .Include(sd => sd.Product) 
                .Include(sd => sd.Sale)    
                .ToListAsync();
        }

    }
}

