using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentSystem.Migrations
{
    public partial class addedsettlementAmountcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "SettlementAmount",
                table: "Payments",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SettlementAmount",
                table: "Payments");
        }
    }
}
