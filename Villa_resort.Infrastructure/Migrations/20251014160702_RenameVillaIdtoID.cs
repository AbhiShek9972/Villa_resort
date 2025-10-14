using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa_resort.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameVillaIdtoID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers");

            migrationBuilder.RenameColumn(
                name: "VillaID",
                table: "VillaNumbers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                newName: "IX_VillaNumbers_Id");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 14, 21, 37, 1, 181, DateTimeKind.Local).AddTicks(2040), new DateTime(2025, 10, 14, 21, 37, 1, 181, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 14, 21, 37, 1, 181, DateTimeKind.Local).AddTicks(2052), new DateTime(2025, 10, 14, 21, 37, 1, 181, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_Id",
                table: "VillaNumbers",
                column: "Id",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VillaNumbers_Villas_Id",
                table: "VillaNumbers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "VillaNumbers",
                newName: "VillaID");

            migrationBuilder.RenameIndex(
                name: "IX_VillaNumbers_Id",
                table: "VillaNumbers",
                newName: "IX_VillaNumbers_VillaID");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 8, 21, 59, 55, 97, DateTimeKind.Local).AddTicks(2837), new DateTime(2025, 10, 8, 21, 59, 55, 97, DateTimeKind.Local).AddTicks(2839) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2025, 10, 8, 21, 59, 55, 97, DateTimeKind.Local).AddTicks(2846), new DateTime(2025, 10, 8, 21, 59, 55, 97, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.AddForeignKey(
                name: "FK_VillaNumbers_Villas_VillaID",
                table: "VillaNumbers",
                column: "VillaID",
                principalTable: "Villas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
