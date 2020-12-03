using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIFlowers.Migrations
{
    public partial class lastplz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RevisionFlower_Flower_FlowerId",
                table: "RevisionFlower");

            migrationBuilder.DropForeignKey(
                name: "FK_RevisionFlower_Revision_RevisionId1",
                table: "RevisionFlower");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RevisionFlower",
                table: "RevisionFlower");

            migrationBuilder.DropIndex(
                name: "IX_RevisionFlower_FlowerId",
                table: "RevisionFlower");

            migrationBuilder.DropIndex(
                name: "IX_RevisionFlower_RevisionId1",
                table: "RevisionFlower");

            migrationBuilder.DropColumn(
                name: "RevisionId1",
                table: "RevisionFlower");

            migrationBuilder.AlterColumn<int>(
                name: "FlowerId",
                table: "RevisionFlower",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RevisionId",
                table: "RevisionFlower",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RevisionFlower",
                table: "RevisionFlower",
                columns: new[] { "FlowerId", "RevisionId" });

            migrationBuilder.CreateIndex(
                name: "IX_RevisionFlower_RevisionId",
                table: "RevisionFlower",
                column: "RevisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_RevisionFlower_Flower_FlowerId",
                table: "RevisionFlower",
                column: "FlowerId",
                principalTable: "Flower",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RevisionFlower_Revision_RevisionId",
                table: "RevisionFlower",
                column: "RevisionId",
                principalTable: "Revision",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RevisionFlower_Flower_FlowerId",
                table: "RevisionFlower");

            migrationBuilder.DropForeignKey(
                name: "FK_RevisionFlower_Revision_RevisionId",
                table: "RevisionFlower");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RevisionFlower",
                table: "RevisionFlower");

            migrationBuilder.DropIndex(
                name: "IX_RevisionFlower_RevisionId",
                table: "RevisionFlower");

            migrationBuilder.AlterColumn<int>(
                name: "RevisionId",
                table: "RevisionFlower",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "FlowerId",
                table: "RevisionFlower",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RevisionId1",
                table: "RevisionFlower",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RevisionFlower",
                table: "RevisionFlower",
                column: "RevisionId");

            migrationBuilder.CreateIndex(
                name: "IX_RevisionFlower_FlowerId",
                table: "RevisionFlower",
                column: "FlowerId");

            migrationBuilder.CreateIndex(
                name: "IX_RevisionFlower_RevisionId1",
                table: "RevisionFlower",
                column: "RevisionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_RevisionFlower_Flower_FlowerId",
                table: "RevisionFlower",
                column: "FlowerId",
                principalTable: "Flower",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RevisionFlower_Revision_RevisionId1",
                table: "RevisionFlower",
                column: "RevisionId1",
                principalTable: "Revision",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
