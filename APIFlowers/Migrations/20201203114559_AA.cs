using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIFlowers.Migrations
{
    public partial class AA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flower_WinterHardiness_WinterHardinessId",
                table: "Flower");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RevisionFlower",
                table: "RevisionFlower");

            migrationBuilder.AlterColumn<int>(
                name: "RevisionId",
                table: "RevisionFlower",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "FlowerId",
                table: "RevisionFlower",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<ulong>(
                name: "ClientPhone",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Order",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WinterHardinessId",
                table: "Flower",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RevisionFlower",
                table: "RevisionFlower",
                columns: new[] { "FlowerId", "RevisionId" });

            migrationBuilder.CreateIndex(
                name: "IX_RevisionFlower_RevisionId",
                table: "RevisionFlower",
                column: "RevisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientPhone",
                table: "Order",
                column: "ClientPhone");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ServiceId",
                table: "Order",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StatusId",
                table: "Order",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowerAreaFlower_FlowerId",
                table: "FlowerAreaFlower",
                column: "FlowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Flower_AromaId",
                table: "Flower",
                column: "AromaId");

            migrationBuilder.CreateIndex(
                name: "IX_Flower_ColorId",
                table: "Flower",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Flower_FlowerKindId",
                table: "Flower",
                column: "FlowerKindId");

            migrationBuilder.CreateIndex(
                name: "IX_BouquetFlower_FlowerId",
                table: "BouquetFlower",
                column: "FlowerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BouquetFlower_Flower_FlowerId",
                table: "BouquetFlower",
                column: "FlowerId",
                principalTable: "Flower",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flower_Aroma_AromaId",
                table: "Flower",
                column: "AromaId",
                principalTable: "Aroma",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flower_Color_ColorId",
                table: "Flower",
                column: "ColorId",
                principalTable: "Color",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flower_FlowerKind_FlowerKindId",
                table: "Flower",
                column: "FlowerKindId",
                principalTable: "FlowerKind",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flower_WinterHardiness_WinterHardinessId",
                table: "Flower",
                column: "WinterHardinessId",
                principalTable: "WinterHardiness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowerAreaFlower_FlowerArea_FlowerAreaId",
                table: "FlowerAreaFlower",
                column: "FlowerAreaId",
                principalTable: "FlowerArea",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowerAreaFlower_Flower_FlowerId",
                table: "FlowerAreaFlower",
                column: "FlowerId",
                principalTable: "Flower",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowerBalance_Flower_FlowerId",
                table: "FlowerBalance",
                column: "FlowerId",
                principalTable: "Flower",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Client_ClientPhone",
                table: "Order",
                column: "ClientPhone",
                principalTable: "Client",
                principalColumn: "Phone",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Service_ServiceId",
                table: "Order",
                column: "ServiceId",
                principalTable: "Service",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Status_StatusId",
                table: "Order",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_BouquetFlower_Flower_FlowerId",
                table: "BouquetFlower");

            migrationBuilder.DropForeignKey(
                name: "FK_Flower_Aroma_AromaId",
                table: "Flower");

            migrationBuilder.DropForeignKey(
                name: "FK_Flower_Color_ColorId",
                table: "Flower");

            migrationBuilder.DropForeignKey(
                name: "FK_Flower_FlowerKind_FlowerKindId",
                table: "Flower");

            migrationBuilder.DropForeignKey(
                name: "FK_Flower_WinterHardiness_WinterHardinessId",
                table: "Flower");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowerAreaFlower_FlowerArea_FlowerAreaId",
                table: "FlowerAreaFlower");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowerAreaFlower_Flower_FlowerId",
                table: "FlowerAreaFlower");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowerBalance_Flower_FlowerId",
                table: "FlowerBalance");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Client_ClientPhone",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Service_ServiceId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Status_StatusId",
                table: "Order");

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

            migrationBuilder.DropIndex(
                name: "IX_Order_ClientPhone",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ServiceId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_StatusId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_FlowerAreaFlower_FlowerId",
                table: "FlowerAreaFlower");

            migrationBuilder.DropIndex(
                name: "IX_Flower_AromaId",
                table: "Flower");

            migrationBuilder.DropIndex(
                name: "IX_Flower_ColorId",
                table: "Flower");

            migrationBuilder.DropIndex(
                name: "IX_Flower_FlowerKindId",
                table: "Flower");

            migrationBuilder.DropIndex(
                name: "IX_BouquetFlower_FlowerId",
                table: "BouquetFlower");

            migrationBuilder.DropColumn(
                name: "FlowerId",
                table: "RevisionFlower");

            migrationBuilder.DropColumn(
                name: "ClientPhone",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Order");

            migrationBuilder.AlterColumn<int>(
                name: "RevisionId",
                table: "RevisionFlower",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "WinterHardinessId",
                table: "Flower",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RevisionFlower",
                table: "RevisionFlower",
                column: "RevisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flower_WinterHardiness_WinterHardinessId",
                table: "Flower",
                column: "WinterHardinessId",
                principalTable: "WinterHardiness",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
