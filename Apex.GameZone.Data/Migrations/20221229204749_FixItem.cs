using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Apex.GameZone.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_GameZones_GameZoneEntityId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_GameZoneEntityId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "GameZoneEntityId",
                table: "Items");

            migrationBuilder.CreateIndex(
                name: "IX_Items_GameZoneId",
                table: "Items",
                column: "GameZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_GameZones_GameZoneId",
                table: "Items",
                column: "GameZoneId",
                principalTable: "GameZones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_GameZones_GameZoneId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_GameZoneId",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "GameZoneEntityId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_GameZoneEntityId",
                table: "Items",
                column: "GameZoneEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_GameZones_GameZoneEntityId",
                table: "Items",
                column: "GameZoneEntityId",
                principalTable: "GameZones",
                principalColumn: "Id");
        }
    }
}
