using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class InventoryDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Get connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string not found in appsettings.json.");
            }

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        public virtual DbSet<SalesDetails> SalesDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<SalesDetails>()
                .HasKey(sd => new { sd.ProductId, sd.SaleId });

            modelBuilder.Entity<SalesDetails>()
                .HasOne(sd => sd.Product)
                .WithMany(p => p.SalesDetails)
                .HasForeignKey(sd => sd.ProductId);

            modelBuilder.Entity<SalesDetails>()
                .HasOne(sd => sd.Sale)
                .WithMany(s => s.SalesDetails)
                .HasForeignKey(sd => sd.SaleId);

            modelBuilder.Entity<Stock>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Stocks)
                .HasForeignKey(s => s.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Stock>()
                .HasKey(s => new { s.LastUpdate, s.ProductId });
        }
    }
}
