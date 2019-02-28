using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SP19.P2.Web.Migrations
{
    public partial class PaymentOptionDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentOption",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "PaymentOptionsPaymentOptionID",
                table: "Customers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentOptions",
                columns: table => new
                {
                    PaymentOptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nickname = table.Column<string>(nullable: true),
                    TokenizedCardSystem = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOptions", x => x.PaymentOptionID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PaymentOptionsPaymentOptionID",
                table: "Customers",
                column: "PaymentOptionsPaymentOptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_PaymentOptions_PaymentOptionsPaymentOptionID",
                table: "Customers",
                column: "PaymentOptionsPaymentOptionID",
                principalTable: "PaymentOptions",
                principalColumn: "PaymentOptionID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_PaymentOptions_PaymentOptionsPaymentOptionID",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "PaymentOptions");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PaymentOptionsPaymentOptionID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PaymentOptionsPaymentOptionID",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "PaymentOption",
                table: "Customers",
                nullable: true);
        }
    }
}
