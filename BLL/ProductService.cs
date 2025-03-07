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
    public class ProductService
    {
        private readonly InventoryDbContext dbContext;
        public ProductService()
        {
            dbContext = new InventoryDbContext();
        }
        public void Add(string name,decimal price,int categoryId,int supplierId,int quantity)
        {
            var newProduct = dbContext.Products.FirstOrDefault(p => p.Name == name);
            if (newProduct == null)
            {
                Product product = new Product()
                {
                    Name = name,
                    Price = price,
                    CategoryId = categoryId,
                    SupplierId = supplierId
                };

                dbContext.Products.Add(product);
                var affectChanges = dbContext.SaveChanges();
                if(affectChanges > 0)
                {
                    var lastProduct = dbContext.Products.LastOrDefault();
                    Stock stock = new Stock()
                    {
                        Type = "Supply",
                        Quantity =quantity,
                        LastUpdate = DateTime.Now,
                        ProductId = lastProduct!.ProductId
                    };
                    dbContext.Stocks.Add(stock);
                    dbContext.SaveChanges();

                }
            }
            else
            {
                var oldtStok = dbContext.Stocks.LastOrDefault(p=>p.ProductId == newProduct.ProductId);
                Stock stock = new Stock()
                {
                    Type = "Supply",
                    Quantity = oldtStok!.Quantity + quantity,
                    LastUpdate = DateTime.Now,
                    ProductId = newProduct.ProductId,
                };
                dbContext.Stocks.Add(stock);
                dbContext.SaveChanges();
            }
        }
        public void Update(int id,string name, decimal price, int categoryId, int supplierId)
        {
            //validate on categoryId - supplierId
            var product =GetById(id);
            if(product != null)
            {
                product.Name = name;
                product.Price = price;
                product.CategoryId = categoryId;
                product.SupplierId = supplierId;

                dbContext.Products.Update(product);
                dbContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var product = dbContext.Products.Where(p =>p.ProductId == id).FirstOrDefault();

            if (product != null)
            {
                dbContext.Products.Remove(product);
                dbContext.SaveChanges();
            }
        }
        public IEnumerable<Product> GetAll()
        {
            //return all products   (exist and not exist in stock)
            //return dbContext.Products.Include(p => p.Category).Include(p => p.Supplier).ToList();
            //return dbContext.Products.ToList();

            //return only products that have quantity in stock
            var product = dbContext.Products.Include(p => p.Category)
                                     .Include(p => p.Supplier)
                                     .Include(p => p.Stocks)
                                     .Where(p => p.Stocks.Any(s => s.Quantity > 0 && s.Type == "Supply"));
            return product;
        }
        public Product? GetById(int id)
        {
            //return dbContext.Products.Where(p => p.ProductId == id).FirstOrDefault();
            var product = dbContext.Products.Where(p => p.ProductId == id)
                                     .Include(p => p.Category)
                                     .Include(p => p.Supplier)
                                     .Include(p => p.Stocks)
                                     .FirstOrDefault();

            if(product != null)
            {
                return product;
            }
            return null;
        }
        public IEnumerable<Product> Search(string name, int? categoryId, int? sypplierId)
        {
            var query = dbContext.Products.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name == name);
            }

            if (categoryId != null)
            {
                query = query.Where(p => p.CategoryId == categoryId);
            }
            if (sypplierId != null)
            {
                query = query.Where(p => p.SupplierId == sypplierId);
            }

            //return query.ToList();
            return query.Include(p => p.Category).Include(p => p.Supplier).ToList();
        }
        public Product ViewDetails(int id)
        {
            return GetById(id)!;
        }
    }
}
