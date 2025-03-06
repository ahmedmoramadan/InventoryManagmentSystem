using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagmentSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Laptops" },
                    { 2, "Dell Laptops" },
                    { 3, "HP Laptops" },
                    { 4, "Apple Laptops" },
                    { 5, "Lenovo Laptops" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "Contact", "Name" },
                values: new object[,]
                {
                    { 1, "One Dell Way, Round Rock, TX 78682, USA", "+1 800-456-3355", "Dell Technologies" },
                    { 2, "1501 Page Mill Road, Palo Alto, CA 94304, USA", "+1 800-474-6836", "HP Inc." },
                    { 3, "1 Infinite Loop, Cupertino, CA 95014, USA", "+1 800-275-2273", "Apple Inc." },
                    { 4, "6/F, Lenovo Building, 29 Science Park Road, Hong Kong", "+852 2833 2111", "Lenovo Group Limited" },
                    { 5, "3351 Michelson Drive, Suite 100, Irvine, CA 92612, USA", "+1 800-456-8000", "Ingram Micro" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
