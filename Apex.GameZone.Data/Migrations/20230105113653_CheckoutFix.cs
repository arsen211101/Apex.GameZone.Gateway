using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apex.GameZone.Data.Migrations
{
    /// <inheritdoc />
    public partial class CheckoutFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_GameZones_GameZoneId",
                table: "Checkouts");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_GameZoneId",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "GameZoneId",
                table: "Checkouts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameZoneId",
                table: "Checkouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_GameZoneId",
                table: "Checkouts",
                column: "GameZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_GameZones_GameZoneId",
                table: "Checkouts",
                column: "GameZoneId",
                principalTable: "GameZones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
