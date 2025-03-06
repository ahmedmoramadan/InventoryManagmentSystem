﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using Microsoft.Extensions.Configuration;
//using System.Configuration;

namespace DAL
{
    public class InventoryDbContext :DbContext
    {
        //public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) { }
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
            modelBuilder.Entity<Category>().HasData(
    new Category { Id = 1, Name = "Laptops" },
    new Category { Id = 2, Name = "Dell Laptops" },
    new Category { Id = 3, Name = "HP Laptops" },
    new Category { Id = 4, Name = "Apple Laptops" },
    new Category { Id = 5, Name = "Lenovo Laptops" }
);

            // Seed data for Supplier - Adding suppliers for laptops
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "Dell Technologies", Address = "One Dell Way, Round Rock, TX 78682, USA", Contact = "+1 800-456-3355" },
                new Supplier { Id = 2, Name = "HP Inc.", Address = "1501 Page Mill Road, Palo Alto, CA 94304, USA", Contact = "+1 800-474-6836" },
                new Supplier { Id = 3, Name = "Apple Inc.", Address = "1 Infinite Loop, Cupertino, CA 95014, USA", Contact = "+1 800-275-2273" },
                new Supplier { Id = 4, Name = "Lenovo Group Limited", Address = "6/F, Lenovo Building, 29 Science Park Road, Hong Kong", Contact = "+852 2833 2111" },
                new Supplier { Id = 5, Name = "Ingram Micro", Address = "3351 Michelson Drive, Suite 100, Irvine, CA 92612, USA", Contact = "+1 800-456-8000" }
            );


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
