using System;
using System.Collections.Generic;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class SaleDetailsService
    {
        private readonly InventoryDbContext _context;

        public SaleDetailsService()
        {
            _context = new InventoryDbContext();
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
        public string GetBestSellingProduct()
        {
            var bestSellingProd = _context.SalesDetails
                .GroupBy(s => s.ProductId)
                .Select(g => new { ProductId = g.Key, TotalQuantitySold = g.Sum(s => s.Quantity) })
                .OrderByDescending(p => p.TotalQuantitySold)
                .FirstOrDefault();
            if(bestSellingProd == null)
            {
                return "No Sales Data Available";
            }
            var Prod = _context.Products.Find(bestSellingProd.ProductId);
            return Prod != null ? Prod.Name : "No Sales Data Available";
        }
        public bool AddSalesDetails(int saleId, int productId, int quantity)
        {
            var sale = _context.Sales.FirstOrDefault(s => s.Id == saleId);
            var Product = _context.Products.Find(productId);
            var unitprice = Product!.Price;
            var oldStock = _context.Stocks.OrderBy(t => t.LastUpdate).LastOrDefault(l => l.ProductId == productId);
            if (sale == null || oldStock == null || oldStock.Quantity < quantity)
                return false;
            var newsale = new SalesDetails()
            {
                SaleId = saleId,
                ProductId = productId,
                unitPrice = unitprice,
                Price = unitprice * quantity,
                Quantity = quantity
            };
            _context.SalesDetails.Add(newsale);

            //update sale total price
            sale.Total_Price += unitprice * quantity;
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
        public List<SalesDetails> GetSaleDetailsById(int id)
        {
            return _context.SalesDetails.Where(i => i.SaleId == id).ToList();
        }
    }
}
