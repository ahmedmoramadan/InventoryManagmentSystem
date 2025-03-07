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
            var product = _context.Products.Find(productId);
            if (product == null)
            {
                return false; // Product not found
            }

            var sale = _context.Sales.Find(saleId);
            if (sale == null)
            {
                return false; // Sale not found
            }

            var salesDetails = new SalesDetails
            {
                SaleId = saleId,
                ProductId = productId,
                Quantity = quantity,
                unitPrice = price,
                Price = price * quantity,
            };

            _context.SalesDetails.Add(salesDetails);

            // Update the total price of the sale
            sale.Total_Price += price;
            _context.Sales.Update(sale);

            var rowsAffected = _context.SaveChanges();
            if (rowsAffected > 0) 
            {
                var oldtStok = _context.Stocks.LastOrDefault(p => p.ProductId == productId);
                Stock stock = new Stock()
                {
                    Type = "Sale",
                    Quantity = oldtStok.Quantity - quantity,
                    LastUpdate = DateTime.Now,
                    ProductId = productId,
                };
                _context.Stocks.Add(stock);
                _context.SaveChanges();
            }
            return rowsAffected > 0;
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
