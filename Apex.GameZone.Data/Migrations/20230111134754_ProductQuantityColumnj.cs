using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apex.GameZone.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProductQuantityColumnj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductCheckoutMapping",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductCheckoutMapping");
        }
    }
}
