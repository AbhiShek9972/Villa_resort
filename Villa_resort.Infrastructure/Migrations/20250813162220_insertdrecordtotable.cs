using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Villa_resort.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class insertdrecordtotable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 8, 13, 21, 52, 19, 942, DateTimeKind.Local).AddTicks(3753), "A luxurious villa with royal amenities.", "https://example.com/images/royal_villa.jpg", "Royal Villa", 4, 250.0, 1500, new DateTime(2025, 8, 13, 21, 52, 19, 942, DateTimeKind.Local).AddTicks(3754) },
                    { 2, new DateTime(2025, 8, 13, 21, 52, 19, 942, DateTimeKind.Local).AddTicks(3758), "A beautiful villa located right on the beach.", "https://example.com/images/beachfront_villa.jpg", "Beachfront Villa", 6, 300.0, 1800, new DateTime(2025, 8, 13, 21, 52, 19, 942, DateTimeKind.Local).AddTicks(3759) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
