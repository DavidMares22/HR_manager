using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_manager.Server.Migrations
{
    public partial class EmpData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_AspNetUsers_EmployeeId",
                table: "EmployeeData");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_Departments_DepartmentId",
                table: "EmployeeData");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_EmployeeType_EmployeeTypeId",
                table: "EmployeeData");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeData_DepartmentId",
                table: "EmployeeData");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeData_EmployeeId",
                table: "EmployeeData");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeData_EmployeeTypeId",
                table: "EmployeeData");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EmployeeData");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeData");

            migrationBuilder.DropColumn(
                name: "EmployeeTypeId",
                table: "EmployeeData");

            migrationBuilder.AlterColumn<string>(
                name: "FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87f6a76a-b59a-4dd7-86f1-230c1ddfd5eb", "5777416a-b77a-4954-8486-cad0b843ebc2", "User", "USER" },
                    { "0b39c41b-464f-4bab-8522-c5db7e284be1", "ac949223-1c10-4723-a4c5-c316f9269f7d", "Administrator", "ADMINISTRATOR" }
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

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_FK_EmployeeData_To_Department",
                table: "EmployeeData",
                column: "FK_EmployeeData_To_Department");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                column: "FK_EmployeeData_To_Employee");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_FK_EmployeeData_To_EmployeeType",
                table: "EmployeeData",
                column: "FK_EmployeeData_To_EmployeeType");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_AspNetUsers_FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                column: "FK_EmployeeData_To_Employee",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_Departments_FK_EmployeeData_To_Department",
                table: "EmployeeData",
                column: "FK_EmployeeData_To_Department",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_EmployeeType_FK_EmployeeData_To_EmployeeType",
                table: "EmployeeData",
                column: "FK_EmployeeData_To_EmployeeType",
                principalTable: "EmployeeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_AspNetUsers_FK_EmployeeData_To_Employee",
                table: "EmployeeData");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_Departments_FK_EmployeeData_To_Department",
                table: "EmployeeData");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeData_EmployeeType_FK_EmployeeData_To_EmployeeType",
                table: "EmployeeData");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeData_FK_EmployeeData_To_Department",
                table: "EmployeeData");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeData_FK_EmployeeData_To_Employee",
                table: "EmployeeData");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeData_FK_EmployeeData_To_EmployeeType",
                table: "EmployeeData");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b39c41b-464f-4bab-8522-c5db7e284be1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87f6a76a-b59a-4dd7-86f1-230c1ddfd5eb");

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

            migrationBuilder.AlterColumn<string>(
                name: "FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "EmployeeData",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "EmployeeData",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeTypeId",
                table: "EmployeeData",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_DepartmentId",
                table: "EmployeeData",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_EmployeeId",
                table: "EmployeeData",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeData_EmployeeTypeId",
                table: "EmployeeData",
                column: "EmployeeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_AspNetUsers_EmployeeId",
                table: "EmployeeData",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_Departments_DepartmentId",
                table: "EmployeeData",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeData_EmployeeType_EmployeeTypeId",
                table: "EmployeeData",
                column: "EmployeeTypeId",
                principalTable: "EmployeeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
