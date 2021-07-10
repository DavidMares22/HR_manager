using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_manager.Server.Migrations
{
    public partial class SeedDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f3a673e-3e2e-4cf4-9d66-ac323421736d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cace9342-1f41-4771-a3d2-c6b51461959a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e630df89-4f97-4e11-a817-7c58dbf0cd38", "7142a709-d828-4fe5-bbf6-a08445bfdf4a", "User", "USER" },
                    { "6b350b63-da5a-4fe1-9eed-f88726842ba4", "ebaae74d-f51e-4b63-8398-5cea9fabec0e", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "Management" },
                    { 3, "Sales" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b350b63-da5a-4fe1-9eed-f88726842ba4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e630df89-4f97-4e11-a817-7c58dbf0cd38");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f3a673e-3e2e-4cf4-9d66-ac323421736d", "22808a11-a59c-4909-a483-5e9b0459e014", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cace9342-1f41-4771-a3d2-c6b51461959a", "73344773-6693-43c0-b74f-f75f524c4fd5", "Administrator", "ADMINISTRATOR" });
        }
    }
}
