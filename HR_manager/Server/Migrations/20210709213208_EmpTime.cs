using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_manager.Server.Migrations
{
    public partial class EmpTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTime_AspNetUsers_FK_EmployeeTime_to_Employee",
                table: "EmployeeTime");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTime_LoggedTime_FK_EmployeeTime_to_LoggedTime",
                table: "EmployeeTime");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTime_FK_EmployeeTime_to_Employee",
                table: "EmployeeTime");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeTime_FK_EmployeeTime_to_LoggedTime",
                table: "EmployeeTime");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09143de3-0a1d-4bdd-b1cf-19a06ee475e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f2252d3-1937-4c61-b8fe-1af14503abbf");

            migrationBuilder.AlterColumn<int>(
                name: "FK_EmployeeTime_to_LoggedTime",
                table: "EmployeeTime",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FK_EmployeeTime_to_Employee",
                table: "EmployeeTime",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "44339e33-ecca-411d-bef9-b51f13a2d025", "89c47daa-1fff-4876-8be4-16b3a41936c3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cc76234a-3f96-4104-a450-5daede00ff36", "12247b71-27ad-4ecb-b2ff-c7b531a940f5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44339e33-ecca-411d-bef9-b51f13a2d025");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc76234a-3f96-4104-a450-5daede00ff36");

            migrationBuilder.AlterColumn<int>(
                name: "FK_EmployeeTime_to_LoggedTime",
                table: "EmployeeTime",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FK_EmployeeTime_to_Employee",
                table: "EmployeeTime",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f2252d3-1937-4c61-b8fe-1af14503abbf", "fd230fa0-bfb3-4b15-a752-8110c51d9bda", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09143de3-0a1d-4bdd-b1cf-19a06ee475e2", "2afb7636-a23f-4476-8b6f-9bd25650f5f7", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTime_FK_EmployeeTime_to_Employee",
                table: "EmployeeTime",
                column: "FK_EmployeeTime_to_Employee");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTime_FK_EmployeeTime_to_LoggedTime",
                table: "EmployeeTime",
                column: "FK_EmployeeTime_to_LoggedTime");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTime_AspNetUsers_FK_EmployeeTime_to_Employee",
                table: "EmployeeTime",
                column: "FK_EmployeeTime_to_Employee",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTime_LoggedTime_FK_EmployeeTime_to_LoggedTime",
                table: "EmployeeTime",
                column: "FK_EmployeeTime_to_LoggedTime",
                principalTable: "LoggedTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
