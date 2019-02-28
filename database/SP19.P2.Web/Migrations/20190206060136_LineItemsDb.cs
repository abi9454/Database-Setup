using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SP19.P2.Web.Migrations
{
    public partial class LineItemsDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Receipts",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "LineItems",
                table: "Receipts");

            migrationBuilder.AddColumn<int>(
                name: "ReceiptId",
                table: "Receipts",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "LineItemsLineId",
                table: "Receipts",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receipts",
                table: "Receipts",
                column: "ReceiptId");

            migrationBuilder.CreateTable(
                name: "LineItems",
                columns: table => new
                {
                    LineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    PerItemCost = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineItems", x => x.LineId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_LineItemsLineId",
                table: "Receipts",
                column: "LineItemsLineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Receipts_LineItems_LineItemsLineId",
                table: "Receipts",
                column: "LineItemsLineId",
                principalTable: "LineItems",
                principalColumn: "LineId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receipts_LineItems_LineItemsLineId",
                table: "Receipts");

            migrationBuilder.DropTable(
                name: "LineItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Receipts",
                table: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Receipts_LineItemsLineId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "ReceiptId",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "LineItemsLineId",
                table: "Receipts");

            migrationBuilder.AddColumn<string>(
                name: "LineItems",
                table: "Receipts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Receipts",
                table: "Receipts",
                column: "LineItems");
        }
    }
}
