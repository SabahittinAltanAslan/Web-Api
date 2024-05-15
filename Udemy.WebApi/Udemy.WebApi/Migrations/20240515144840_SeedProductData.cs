using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Udemy.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "ImagePath", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 12, 17, 48, 40, 141, DateTimeKind.Local).AddTicks(1333), "/img/Pc", "Bilgisayar", 15000m, 3000 },
                    { 2, new DateTime(2024, 4, 15, 17, 48, 40, 141, DateTimeKind.Local).AddTicks(1360), "/img/Phone", "Telefon", 10000m, 500 },
                    { 3, new DateTime(2024, 3, 16, 17, 48, 40, 141, DateTimeKind.Local).AddTicks(1361), "/img/Klavye", "Klavye", 100m, 1000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
