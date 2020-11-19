using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Update_Foreignkey_scheduledate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleDates_Employees_EmployeeId1",
                table: "ScheduleDates");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleDates_Locations_LocationId1",
                table: "ScheduleDates");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleDates_EmployeeId1",
                table: "ScheduleDates");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleDates_LocationId1",
                table: "ScheduleDates");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf747556-ec10-4e5e-be61-e83293f2fcfe");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "ScheduleDates");

            migrationBuilder.DropColumn(
                name: "LocationId1",
                table: "ScheduleDates");

            migrationBuilder.AlterColumn<int>(
                name: "LocationId",
                table: "ScheduleDates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "ScheduleDates",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "07177f1b-bc15-411f-a06b-4c483797b52f", "9bbf9685-0b65-4ba1-b8aa-b4da4c46939f", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDates_EmployeeId",
                table: "ScheduleDates",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDates_LocationId",
                table: "ScheduleDates",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleDates_Employees_EmployeeId",
                table: "ScheduleDates",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleDates_Locations_LocationId",
                table: "ScheduleDates",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleDates_Employees_EmployeeId",
                table: "ScheduleDates");

            migrationBuilder.DropForeignKey(
                name: "FK_ScheduleDates_Locations_LocationId",
                table: "ScheduleDates");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleDates_EmployeeId",
                table: "ScheduleDates");

            migrationBuilder.DropIndex(
                name: "IX_ScheduleDates_LocationId",
                table: "ScheduleDates");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07177f1b-bc15-411f-a06b-4c483797b52f");

            migrationBuilder.AlterColumn<string>(
                name: "LocationId",
                table: "ScheduleDates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "ScheduleDates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "ScheduleDates",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId1",
                table: "ScheduleDates",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf747556-ec10-4e5e-be61-e83293f2fcfe", "a26b4705-dfc3-495a-8bae-b618afd6f5ff", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDates_EmployeeId1",
                table: "ScheduleDates",
                column: "EmployeeId1");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleDates_LocationId1",
                table: "ScheduleDates",
                column: "LocationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleDates_Employees_EmployeeId1",
                table: "ScheduleDates",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ScheduleDates_Locations_LocationId1",
                table: "ScheduleDates",
                column: "LocationId1",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
