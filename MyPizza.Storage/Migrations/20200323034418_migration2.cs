using Microsoft.EntityFrameworkCore.Migrations;

namespace MyPizza.Storage.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Price",
                value: 5.0);

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Price",
                value: 6.5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Price",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Pizza",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Price",
                value: 0.0);
        }
    }
}
