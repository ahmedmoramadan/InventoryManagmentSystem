﻿// <auto-generated />
using System;
using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InventoryManagmentSystem.DAL.Migrations
{
    [DbContext(typeof(InventoryDbContext))]
    [Migration("20250307225217_SeedProductsData")]
    partial class SeedProductsData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Asus Laptops"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dell Laptops"
                        },
                        new
                        {
                            Id = 3,
                            Name = "HP Laptops"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Apple Laptops"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Lenovo Laptops"
                        });
                });

            modelBuilder.Entity("DAL.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            Name = "Dell XPS 13",
                            Price = 12000m,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 3,
                            Name = "HP Spectre x360",
                            Price = 11000m,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 4,
                            Name = "MacBook Pro 14",
                            Price = 20000m,
                            SupplierId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 5,
                            Name = "Lenovo ThinkPad X1",
                            Price = 13000m,
                            SupplierId = 4
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            Name = "Asus ROG Zephyrus G14",
                            Price = 15000m,
                            SupplierId = 5
                        });
                });

            modelBuilder.Entity("DAL.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Customer_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total_Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("DAL.Models.SalesDetails", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("unitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "SaleId");

                    b.HasIndex("SaleId");

                    b.ToTable("SalesDetails");
                });

            modelBuilder.Entity("DAL.Models.Stock", b =>
                {
                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("LastUpdate", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("DAL.Models.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Contact")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "One Dell Way, Round Rock, TX 78682, USA",
                            Contact = "+1 800-456-3355",
                            Name = "Dell Technologies"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1501 Page Mill Road, Palo Alto, CA 94304, USA",
                            Contact = "+1 800-474-6836",
                            Name = "HP Inc."
                        },
                        new
                        {
                            Id = 3,
                            Address = "1 Infinite Loop, Cupertino, CA 95014, USA",
                            Contact = "+1 800-275-2273",
                            Name = "Apple Inc."
                        },
                        new
                        {
                            Id = 4,
                            Address = "6/F, Lenovo Building, 29 Science Park Road, Hong Kong",
                            Contact = "+852 2833 2111",
                            Name = "Lenovo Group Limited"
                        },
                        new
                        {
                            Id = 5,
                            Address = "3351 Michelson Drive, Suite 100, Irvine, CA 92612, USA",
                            Contact = "+1 800-456-8000",
                            Name = "Ingram Micro"
                        });
                });

            modelBuilder.Entity("DAL.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DAL.Models.Product", b =>
                {
                    b.HasOne("DAL.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DAL.Models.SalesDetails", b =>
                {
                    b.HasOne("DAL.Models.Product", "Product")
                        .WithMany("SalesDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Models.Sale", "Sale")
                        .WithMany("SalesDetails")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("DAL.Models.Stock", b =>
                {
                    b.HasOne("DAL.Models.Product", "Product")
                        .WithMany("Stocks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DAL.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DAL.Models.Product", b =>
                {
                    b.Navigation("SalesDetails");

                    b.Navigation("Stocks");
                });

            modelBuilder.Entity("DAL.Models.Sale", b =>
                {
                    b.Navigation("SalesDetails");
                });

            modelBuilder.Entity("DAL.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
