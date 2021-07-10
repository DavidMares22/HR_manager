using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_manager.Server.Migrations
{
    public partial class FKChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_Employees_FK_EmployeeData_To_Employee",
                table: "EmployeeData");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTime_Employees_FK_EmployeeTime_to_Employee",
                table: "EmployeeTime");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d680400-0a81-412d-af43-212b3c2672f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "902943d5-011f-4199-80c1-86a0ecfec0e7");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "LoggedTimeType",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FK_EmployeeTime_to_Employee",
                table: "EmployeeTime",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f3a673e-3e2e-4cf4-9d66-ac323421736d", "22808a11-a59c-4909-a483-5e9b0459e014", "User", "USER" },
                    { "cace9342-1f41-4771-a3d2-c6b51461959a", "73344773-6693-43c0-b74f-f75f524c4fd5", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeType",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Contractor" },
                    { 2, "Permanent" }
                });

            migrationBuilder.InsertData(
                table: "LoggedTimeType",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Regular" },
                    { 2, "Sick" },
                    { 3, "Vacation" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_AspNetUsers_FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                column: "FK_EmployeeData_To_Employee",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTime_AspNetUsers_FK_EmployeeTime_to_Employee",
                table: "EmployeeTime",
                column: "FK_EmployeeTime_to_Employee",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_AspNetUsers_FK_EmployeeData_To_Employee",
                table: "EmployeeData");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTime_AspNetUsers_FK_EmployeeTime_to_Employee",
                table: "EmployeeTime");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f3a673e-3e2e-4cf4-9d66-ac323421736d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cace9342-1f41-4771-a3d2-c6b51461959a");

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoggedTimeType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LoggedTimeType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LoggedTimeType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "LoggedTimeType",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "FK_EmployeeTime_to_Employee",
                table: "EmployeeTime",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6d680400-0a81-412d-af43-212b3c2672f3", "6bbeaa8d-a06a-402d-b513-09d57accb636", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "902943d5-011f-4199-80c1-86a0ecfec0e7", "6bfc5c52-09e3-486e-aa65-b17b1dc12f21", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_Employees_FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                column: "FK_EmployeeData_To_Employee",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTime_Employees_FK_EmployeeTime_to_Employee",
                table: "EmployeeTime",
                column: "FK_EmployeeTime_to_Employee",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
