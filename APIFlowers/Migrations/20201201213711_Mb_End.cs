using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIFlowers.Migrations
{
    public partial class Mb_End : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bouquet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bouquet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flower",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    FlowerKindId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    WinterHardinessId = table.Column<int>(nullable: false),
                    AromaId = table.Column<int>(nullable: false),
                    BasicPrice = table.Column<decimal>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flower", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowerArea",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerArea", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlowerAreaFlower",
                columns: table => new
                {
                    FlowerAreaId = table.Column<int>(nullable: false),
                    Row = table.Column<int>(nullable: false),
                    Column = table.Column<int>(nullable: false),
                    FlowerId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerAreaFlower", x => new { x.FlowerAreaId, x.Row, x.Column });
                });

            migrationBuilder.CreateTable(
                name: "FlowerBalance",
                columns: table => new
                {
                    FlowerId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerBalance", x => new { x.FlowerId, x.Date });
                });

            migrationBuilder.CreateTable(
                name: "FlowerKind",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowerKind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderFlower",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    FlowerId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderFlower", x => new { x.FlowerId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderFlower_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Revision",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revision", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RevisionFlower",
                columns: table => new
                {
                    RevisionId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevisionFlower", x => x.RevisionId);
                });

            migrationBuilder.CreateTable(
                name: "WinterHardiness",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WinterHardiness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BouquetFlower",
                columns: table => new
                {
                    BouquetId = table.Column<int>(nullable: false),
                    FlowerId = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BouquetFlower", x => new { x.BouquetId, x.FlowerId });
                    table.ForeignKey(
                        name: "FK_BouquetFlower_Bouquet_BouquetId",
                        column: x => x.BouquetId,
                        principalTable: "Bouquet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderFlower_OrderId",
                table: "OrderFlower",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BouquetFlower");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Flower");

            migrationBuilder.DropTable(
                name: "FlowerArea");

            migrationBuilder.DropTable(
                name: "FlowerAreaFlower");

            migrationBuilder.DropTable(
                name: "FlowerBalance");

            migrationBuilder.DropTable(
                name: "FlowerKind");

            migrationBuilder.DropTable(
                name: "OrderFlower");

            migrationBuilder.DropTable(
                name: "Revision");

            migrationBuilder.DropTable(
                name: "RevisionFlower");

            migrationBuilder.DropTable(
                name: "WinterHardiness");

            migrationBuilder.DropTable(
                name: "Bouquet");
        }
    }
}
