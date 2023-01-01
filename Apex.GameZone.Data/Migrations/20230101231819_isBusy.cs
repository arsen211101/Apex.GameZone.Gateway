using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apex.GameZone.Data.Migrations
{
    /// <inheritdoc />
    public partial class isBusy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBusy",
                table: "Sections",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBusy",
                table: "Sections");
        }
    }
}
