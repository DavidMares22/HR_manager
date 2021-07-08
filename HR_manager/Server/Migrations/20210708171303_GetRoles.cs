using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_manager.Server.Migrations
{
    public partial class GetRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d680400-0a81-412d-af43-212b3c2672f3", "6bbeaa8d-a06a-402d-b513-09d57accb636", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "902943d5-011f-4199-80c1-86a0ecfec0e7", "6bfc5c52-09e3-486e-aa65-b17b1dc12f21", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d680400-0a81-412d-af43-212b3c2672f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "902943d5-011f-4199-80c1-86a0ecfec0e7");
        }
    }
}
