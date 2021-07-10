using Microsoft.EntityFrameworkCore.Migrations;

namespace HR_manager.Server.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LoggedTime_LoggedTimeType_FK_LoggedTime_To_LoggedTimeType",
                table: "LoggedTime");

            migrationBuilder.DropIndex(
                name: "IX_LoggedTime_FK_LoggedTime_To_LoggedTimeType",
                table: "LoggedTime");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49664064-82cf-4ccd-a733-541a8d7b64c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e41ac5f1-182c-472e-85cc-939a751b274e");

            migrationBuilder.AlterColumn<int>(
                name: "FK_LoggedTime_To_LoggedTimeType",
                table: "LoggedTime",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f2252d3-1937-4c61-b8fe-1af14503abbf", "fd230fa0-bfb3-4b15-a752-8110c51d9bda", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09143de3-0a1d-4bdd-b1cf-19a06ee475e2", "2afb7636-a23f-4476-8b6f-9bd25650f5f7", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09143de3-0a1d-4bdd-b1cf-19a06ee475e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f2252d3-1937-4c61-b8fe-1af14503abbf");

            migrationBuilder.AlterColumn<int>(
                name: "FK_LoggedTime_To_LoggedTimeType",
                table: "LoggedTime",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "49664064-82cf-4ccd-a733-541a8d7b64c2", "c046db7e-ceb3-4f62-9a27-7bb17cd3c3ef", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e41ac5f1-182c-472e-85cc-939a751b274e", "1d4162e2-42ee-4dc2-a374-6183c7eff5d2", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_LoggedTime_FK_LoggedTime_To_LoggedTimeType",
                table: "LoggedTime",
                column: "FK_LoggedTime_To_LoggedTimeType");

            migrationBuilder.AddForeignKey(
                name: "FK_LoggedTime_LoggedTimeType_FK_LoggedTime_To_LoggedTimeType",
                table: "LoggedTime",
                column: "FK_LoggedTime_To_LoggedTimeType",
                principalTable: "LoggedTimeType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
