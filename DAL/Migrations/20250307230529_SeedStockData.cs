using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagmentSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedStockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "LastUpdate", "ProductId", "Quantity", "Type" },
                values: new object[,]
                {
                    { new DateTime(2025, 3, 8, 1, 5, 29, 20, DateTimeKind.Local).AddTicks(8312), 1, 50, "Supply" },
                    { new DateTime(2025, 3, 8, 1, 5, 29, 23, DateTimeKind.Local).AddTicks(3377), 2, 30, "Supply" },
                    { new DateTime(2025, 3, 8, 1, 5, 29, 23, DateTimeKind.Local).AddTicks(3401), 3, 20, "Supply" },
                    { new DateTime(2025, 3, 8, 1, 5, 29, 23, DateTimeKind.Local).AddTicks(3404), 4, 20, "Supply" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2025, 3, 8, 1, 5, 29, 20, DateTimeKind.Local).AddTicks(8312), 1 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2025, 3, 8, 1, 5, 29, 23, DateTimeKind.Local).AddTicks(3377), 2 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2025, 3, 8, 1, 5, 29, 23, DateTimeKind.Local).AddTicks(3401), 3 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2025, 3, 8, 1, 5, 29, 23, DateTimeKind.Local).AddTicks(3404), 4 });
        }
    }
}
