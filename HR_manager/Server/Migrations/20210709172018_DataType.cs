using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_manager.Server.Migrations
{
    public partial class DataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "FK_EmployeeData_To_Employee",
                table: "EmployeeData",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49664064-82cf-4ccd-a733-541a8d7b64c2", "c046db7e-ceb3-4f62-9a27-7bb17cd3c3ef", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e41ac5f1-182c-472e-85cc-939a751b274e", "1d4162e2-42ee-4dc2-a374-6183c7eff5d2", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49664064-82cf-4ccd-a733-541a8d7b64c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e41ac5f1-182c-472e-85cc-939a751b274e");

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
                values: new object[] { "87f6a76a-b59a-4dd7-86f1-230c1ddfd5eb", "5777416a-b77a-4954-8486-cad0b843ebc2", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0b39c41b-464f-4bab-8522-c5db7e284be1", "ac949223-1c10-4723-a4c5-c316f9269f7d", "Administrator", "ADMINISTRATOR" });

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
    }
}
