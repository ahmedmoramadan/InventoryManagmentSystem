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
            new Category { Id = 1, Name = "Smartphones" },
            new Category { Id = 2, Name = "Tablets" },
            new Category { Id = 3, Name = "Accessories" },
            new Category { Id = 4, Name = "Cameras" },
            new Category { Id = 5, Name = "Monitors" },
            new Category { Id = 6, Name = "Laptops" }
            );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "Samsung", Address = "Samsung Town, Seoul, South Korea", Contact = "82 2 2053 3000" },
                new Supplier { Id = 2, Name = "Apple Inc.", Address = "1 Apple Park Way, Cupertino, CA 95014, USA", Contact = "1 800-275-2273" },
                new Supplier { Id = 3, Name = "Sony", Address = "1-7-1 Konan, Minato-ku, Tokyo, Japan", Contact = "81 3 6748 2111" },
                new Supplier { Id = 4, Name = "LG Electronics", Address = "LG Twin Towers, Seoul, South Korea", Contact = "82 2 3777 1114" },
                new Supplier { Id = 5, Name = "Canon", Address = "30-2, Shimomaruko 3-chome, Ota-ku, Tokyo, Japan", Contact = "81 3 3758 2111" },
                new Supplier { Id = 6, Name = "Nikon", Address = "Shinagawa Intercity Tower C, 2-15-3, Konan, Minato-ku, Tokyo, Japan", Contact = "81 3 6433 3600" },
                new Supplier { Id = 7, Name = "Dell", Address = "Round Rock, Texas, USA", Contact = "1 800-624-9897" },
                new Supplier { Id = 8, Name = "HP", Address = "1501 Page Mill Road, Palo Alto, CA 94304, USA", Contact = "1 650-857-1501" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Samsung Galaxy S24", Price = 18000, CategoryId = 1, SupplierId = 1 },
                new Product { ProductId = 2, Name = "iPhone 15 Pro Max", Price = 22000, CategoryId = 1, SupplierId = 2 },
                new Product { ProductId = 3, Name = "iPad Pro 12.9", Price = 17000, CategoryId = 2, SupplierId = 2 },
                new Product { ProductId = 4, Name = "Samsung Galaxy Tab S9", Price = 15000, CategoryId = 2, SupplierId = 1 },
                new Product { ProductId = 5, Name = "Sony Alpha a7 IV", Price = 25000, CategoryId = 4, SupplierId = 3 },
                new Product { ProductId = 6, Name = "LG UltraGear 32", Price = 14000, CategoryId = 5, SupplierId = 4 },
                new Product { ProductId = 7, Name = "Canon EOS R5", Price = 28000, CategoryId = 4, SupplierId = 5 },
                new Product { ProductId = 8, Name = "Nikon Z9", Price = 30000, CategoryId = 4, SupplierId = 6 },
                new Product { ProductId = 9, Name = "Dell XPS 15", Price = 20000, CategoryId = 6, SupplierId = 7 },
                new Product { ProductId = 10, Name = "HP Spectre x360", Price = 18000, CategoryId = 6, SupplierId = 8 }
            );

            modelBuilder.Entity<Stock>().HasData(
                new Stock { ProductId = 1, Type = "Supply", Quantity = 40, LastUpdate = new DateTime(2025, 3, 10) },
                new Stock { ProductId = 2, Type = "Supply", Quantity = 35, LastUpdate = new DateTime(2025, 3, 12) },
                new Stock { ProductId = 3, Type = "Supply", Quantity = 20, LastUpdate = new DateTime(2025, 2, 15) },
                new Stock { ProductId = 4, Type = "Supply", Quantity = 25, LastUpdate = new DateTime(2025, 1, 20) },
                new Stock { ProductId = 5, Type = "Supply", Quantity = 15, LastUpdate = new DateTime(2024, 12, 10) },
                new Stock { ProductId = 6, Type = "Supply", Quantity = 10, LastUpdate = new DateTime(2025, 2, 5) },
                new Stock { ProductId = 7, Type = "Supply", Quantity = 8, LastUpdate = new DateTime(2025, 3, 1) },
                new Stock { ProductId = 8, Type = "Supply", Quantity = 5, LastUpdate = new DateTime(2025, 3, 5) },
                new Stock { ProductId = 9, Type = "Supply", Quantity = 12, LastUpdate = new DateTime(2025, 3, 8) },
                new Stock { ProductId = 10, Type = "Supply", Quantity = 18, LastUpdate = new DateTime(2025, 3, 10) },
                new Stock { ProductId = 1, Type = "Sale", Quantity = 5, LastUpdate = new DateTime(2025, 4, 19) },
                new Stock { ProductId = 2, Type = "Sale", Quantity = 7, LastUpdate = new DateTime(2025, 3, 3) },
                new Stock { ProductId = 3, Type = "Sale", Quantity = 4, LastUpdate = new DateTime(2025, 2, 4) },
                new Stock { ProductId = 4, Type = "Sale", Quantity = 6, LastUpdate = new DateTime(2025, 1, 24) },
                new Stock { ProductId = 5, Type = "Sale", Quantity = 3, LastUpdate = new DateTime(2024, 12, 9) },
                new Stock { ProductId = 6, Type = "Sale", Quantity = 2, LastUpdate = new DateTime(2025, 2, 8) },
                new Stock { ProductId = 7, Type = "Sale", Quantity = 1, LastUpdate = new DateTime(2025, 3, 5) },
                new Stock { ProductId = 8, Type = "Sale", Quantity = 2, LastUpdate = new DateTime(2025, 3, 9) },
                new Stock { ProductId = 9, Type = "Sale", Quantity = 5, LastUpdate = new DateTime(2025, 3, 12) },
                new Stock { ProductId = 10, Type = "Sale", Quantity = 4, LastUpdate = new DateTime(2025, 3, 14) }
            );

            modelBuilder.Entity<Sale>().HasData(
                new Sale { Id = 1, Date = new DateTime(2025, 3, 10), Customer_Name = "Omar", Total_Price = 90000 },
                new Sale { Id = 2, Date = new DateTime(2025, 3, 12), Customer_Name = "Mohamed", Total_Price = 154000 },
                new Sale { Id = 3, Date = new DateTime(2025, 2, 15), Customer_Name = "Ali", Total_Price = 68000 },
                new Sale { Id = 4, Date = new DateTime(2025, 1, 20), Customer_Name = "Nader", Total_Price = 150000 },
                new Sale { Id = 5, Date = new DateTime(2024, 12, 10), Customer_Name = "Ahmed", Total_Price = 84000 },
                new Sale { Id = 6, Date = new DateTime(2025, 3, 14), Customer_Name = "Sara", Total_Price = 56000 }
            );

            modelBuilder.Entity<SalesDetails>().HasData(
                new SalesDetails { ProductId = 1, SaleId = 1, Quantity = 5, Price = 90000, unitPrice = 18000 },
                new SalesDetails { ProductId = 2, SaleId = 2, Quantity = 7, Price = 154000, unitPrice = 22000 },
                new SalesDetails { ProductId = 3, SaleId = 3, Quantity = 4, Price = 68000, unitPrice = 17000 },
                new SalesDetails { ProductId = 5, SaleId = 4, Quantity = 6, Price = 150000, unitPrice = 25000 },
                new SalesDetails { ProductId = 7, SaleId = 5, Quantity = 3, Price = 84000, unitPrice = 28000 },
                new SalesDetails { ProductId = 9, SaleId = 6, Quantity = 2, Price = 40000, unitPrice = 20000 },
                new SalesDetails { ProductId = 10, SaleId = 6, Quantity = 1, Price = 16000, unitPrice = 16000 }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "admin", Password = "123456789", Role = "Admin" }
            );

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Sale>()
                .Property(s => s.Total_Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SalesDetails>()
                .Property(sd => sd.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SalesDetails>()
                .Property(sd => sd.unitPrice)
                .HasColumnType("decimal(18,2)");


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
