using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa_resort.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modifythetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "test",
                table: "Villas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test",
                table: "Villas");
        }
    }
}
