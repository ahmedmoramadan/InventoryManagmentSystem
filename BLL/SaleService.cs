using System;
using System.Collections.Generic;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    class SaleService
    {
        private readonly InventoryDbContext context;

        public SaleService(InventoryDbContext context)
        {
            this.context = context;
        }

        public bool AddSale(DateTime date, string customerName, decimal totalPrice)
        {
            var sale = new Sale
            {
                Date = date,
                Customer_Name = customerName,
                Total_Price = totalPrice
            };

            context.Add(sale);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public bool UpdateSale(int id, DateTime date, string customerName, decimal totalPrice)
        {
            var oldSale = context.Sales.Find(id);
            if (oldSale == null)
            {
                return false;
            }

            oldSale.Customer_Name = customerName;
            oldSale.Date = date;
            oldSale.Total_Price = totalPrice;

            context.Sales.Update(oldSale);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public bool DeleteSale(int id)
        {
            var sale = context.Sales.Find(id);
            if (sale == null)
            {
                return false;
            }

            context.Sales.Remove(sale);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public List<Sale> GetAllSales()
        {
            return context.Sales.ToList();
        }

        public Sale GetSaleById(int id)
        {
            return context.Sales.Find(id);
        }
    }
}
