using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<bool> AddSaleAsync(Sale sale)
        {
            if (sale == null)
            {
                return false;
            }
            await context.AddAsync(sale);
            var rowsAffected = await context.SaveChangesAsync();
          
            return rowsAffected > 0;
        }
        public async Task<bool> UpdateSaleAsync(Sale sale)
        {
            if (sale == null)
            {
                return false;  
            }

            var oldSale = await context.Sales.FindAsync(sale.Id);
            if (oldSale == null)
            {
                return false; 
            }

            oldSale.Customer_Name = sale.Customer_Name;  
            oldSale.Date = sale.Date;
            oldSale.Total_Price = sale.Total_Price;
          

            context.Sales.Update(oldSale);
            var rowsAffected = await context.SaveChangesAsync();
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteSaleAsync(int id)
        {
            var sale = await context.Sales.FindAsync(id);
            if (sale == null)
            {
                return false; 
            }

            context.Sales.Remove(sale);
            var rowsAffected = await context.SaveChangesAsync();
            return rowsAffected > 0;
        }

       
        public async Task<List<Sale>> GetAllSalesAsync()
        {
            return await context.Sales.ToListAsync();
        }

        
        public async Task<Sale> GetSaleByIdAsync(int id)
        {
            return await context.Sales.FindAsync(id);
        }
    }
}

