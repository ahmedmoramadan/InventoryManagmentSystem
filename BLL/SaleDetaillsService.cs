using System;
using System.Collections.Generic;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    class SaleDetailsService
    {
        private readonly InventoryDbContext _context;

        public SaleDetailsService(InventoryDbContext context)
        {
            this._context = context;
        }

        public bool AddSalesDetails(int saleId, int productId, int quantity, decimal price)
        {
            var sale = _context.Sales.FirstOrDefault(s => s.Id == saleId);
            var oldStock = _context.Stocks.LastOrDefault(l => l.ProductId == productId);
            if (sale == null || oldStock == null || oldStock.Quantity < quantity) 
                return false;
            var newsale = new SalesDetails()
            {
                SaleId = saleId,
                ProductId = productId,
                unitPrice = price,
                Price = price * quantity,
                Quantity = quantity
            };
            _context.SalesDetails.Add(newsale);

            //update sale total price
            sale!.Total_Price += price * quantity;
            _context.Sales.Update(sale);

            var newStock = new Stock
            {
                Type = "Sale",
                Quantity = oldStock.Quantity - quantity, // Deduct sold items
                LastUpdate = DateTime.Now,
                ProductId = productId
            };
            _context.Stocks.Add(newStock);

            int effectedrow = _context.SaveChanges();
            return effectedrow > 0;
        }

        public List<SalesDetails> GetAllSalesDetails()
        {
            return _context.SalesDetails
                .Include(sd => sd.Product)  // Include related Product
                .Include(sd => sd.Sale)     // Include related Sale
                .ToList();
        }
    }
}
