using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SP19.P2.Web.Migrations
{
    public partial class ReceiptDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    LineItems = table.Column<string>(nullable: false),
                    TotalAmount = table.Column<int>(nullable: false),
                    PaymentOptionID = table.Column<int>(nullable: true),
                    DateOfPayment = table.Column<DateTime>(nullable: false),
                    PaymentReferenceNumber = table.Column<int>(nullable: false),
                    PaymentAuthNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.LineItems);
                    table.ForeignKey(
                        name: "FK_Receipts_PaymentOptions_PaymentOptionID",
                        column: x => x.PaymentOptionID,
                        principalTable: "PaymentOptions",
                        principalColumn: "PaymentOptionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_PaymentOptionID",
                table: "Receipts",
                column: "PaymentOptionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipts");
        }
    }
}
