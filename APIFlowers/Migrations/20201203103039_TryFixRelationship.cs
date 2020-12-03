using Microsoft.EntityFrameworkCore.Migrations;

namespace APIFlowers.Migrations
{
    public partial class TryFixRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Flower_WinterHardinessId",
                table: "Flower",
                column: "WinterHardinessId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flower_WinterHardiness_WinterHardinessId",
                table: "Flower",
                column: "WinterHardinessId",
                principalTable: "WinterHardiness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flower_WinterHardiness_WinterHardinessId",
                table: "Flower");

            migrationBuilder.DropIndex(
                name: "IX_Flower_WinterHardinessId",
                table: "Flower");
        }
    }
}
