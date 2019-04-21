using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentSystem.Migrations
{
    public partial class addedPaymentseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "CreatedOn", "PaymentType", "SettlementAmount" },
                values: new object[] { 1L, 1000m, new DateTime(2019, 4, 20, 17, 21, 5, 116, DateTimeKind.Local).AddTicks(3866), 1, 998.75m });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "PaymentId", "Amount", "CreatedOn", "PaymentType", "SettlementAmount" },
                values: new object[] { 2L, 678m, new DateTime(2019, 3, 21, 17, 21, 5, 118, DateTimeKind.Local).AddTicks(6195), 2, 676.644m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "PaymentId",
                keyValue: 2L);
        }
    }
}
