using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_manager.Server.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ccf8c5b3-825c-4f0c-bf6c-cff836365163", "35daa659-d1db-45df-be1a-ed8b96bd7c55", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f878be5-9a49-435f-928b-ef3464bbc689", "ffe7fd5b-fabc-4566-95a3-60cdf230802a", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f878be5-9a49-435f-928b-ef3464bbc689");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccf8c5b3-825c-4f0c-bf6c-cff836365163");
        }
    }
}
