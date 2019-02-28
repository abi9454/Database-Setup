using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SP19.P2.Web.Migrations
{
    public partial class TableBillDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TableBills",
                columns: table => new
                {
                    TableBillId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(nullable: true),
                    StartDateTime = table.Column<DateTime>(nullable: false),
                    EndDateTime = table.Column<DateTime>(nullable: false),
                    TableNumberOfSeats = table.Column<string>(nullable: true),
                    TableFoodItemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableBills", x => x.TableBillId);
                    table.ForeignKey(
                        name: "FK_TableBills_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableBills_TableFoodItems_TableFoodItemId",
                        column: x => x.TableFoodItemId,
                        principalTable: "TableFoodItems",
                        principalColumn: "TableFoodItemId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TableBills_Tables_TableNumberOfSeats",
                        column: x => x.TableNumberOfSeats,
                        principalTable: "Tables",
                        principalColumn: "NumberOfSeats",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TableBills_CustomerId",
                table: "TableBills",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_TableBills_TableFoodItemId",
                table: "TableBills",
                column: "TableFoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TableBills_TableNumberOfSeats",
                table: "TableBills",
                column: "TableNumberOfSeats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TableBills");
        }
    }
}
