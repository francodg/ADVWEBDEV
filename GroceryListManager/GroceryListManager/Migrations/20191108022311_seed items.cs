using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryListManager.Migrations
{
    public partial class seeditems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "id", "name", "purchased", "quantity" },
                values: new object[] { 1, "Eggs", false, 1 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "id", "name", "purchased", "quantity" },
                values: new object[] { 2, "Milk", false, 1 });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "id", "name", "purchased", "quantity" },
                values: new object[] { 3, "Bread", false, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
