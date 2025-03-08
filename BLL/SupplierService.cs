using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;

namespace BLL
{
    public class SupplierService
    {
        private readonly InventoryDbContext dbContext;
        public SupplierService()
        {
            dbContext = new InventoryDbContext();
        }

        //Manage supplier details (Name, Contact Info, Address, Product Supply List).
        public bool Add(string name ,string address ,string contact)
        {
            var supplier = new Supplier()
            {
                Name = name,
                Address = address,
                Contact = contact
            };
            dbContext.Suppliers.Add(supplier);
            return dbContext.SaveChanges() > 0;
        }

        public bool update(int id, string name, string address, string contact)
        {
            var supplier = GetById(id);

            if(supplier != null)
            {
                supplier.Name = name;
                supplier.Address = address;
                supplier.Contact = contact;

                dbContext.Suppliers.Update(supplier);
                return dbContext.SaveChanges() > 0;
            }
            return false;
        }
        public bool Delete(int id)
        {
            var supplier = GetById(id);

            if(supplier != null)
            {
                dbContext.Suppliers.Remove(supplier);
                return dbContext.SaveChanges() > 0;
            }
            return false;
        }

        public Supplier? GetById(int id)
        {
            var supplier = dbContext.Suppliers.Where(s => s.Id == id).FirstOrDefault();

            if (supplier != null)
            {
                return supplier;
            }
            return null;
        }

        public List<Supplier> GetAll()
        {
            return dbContext.Suppliers.ToList();
        }



        
        //Track product supply history per supplier.
        //should be in StockService 
        //public IEnumerable<Stock> GetSupplierHistory(int supplierId)
        //{
        //    var supplierHistoryStock = dbContext.Stocks.Where(s => s.Product.SupplierId == supplierId && s.Type == "Supply")
        //                                        .Include(s => s.Product)
        //                                        .ToList();
        //    //// Use "Supply" for supplier deliveries "Sale" for sold good
        //    return supplierHistoryStock;
        //}
        //public IEnumerable<Stock> GetProductHistory(int productId)
        //{
        //    var productHistoryStock = dbContext.Stocks.Where(s => s.ProductId == productId && s.Type == "Supply")
        //                                        .Include(s => s.Product)
        //                                        .ToList();
        //    return productHistoryStock;
        //}
    }
}
