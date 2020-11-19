using Microsoft.EntityFrameworkCore.Migrations;

namespace TrashCollector.Migrations
{
    public partial class Seeding_Customer_and_Employee_Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07177f1b-bc15-411f-a06b-4c483797b52f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6afd900f-ad18-4305-a362-f7e6b60119f8", "ebe051a2-e4c1-4ebe-9510-44d0aea8ea68", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4fa1611b-a893-4a7e-aef6-7d4f7e6129e7", "61f440a4-2121-443c-99c3-83dfaba26997", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "da779c59-41d2-4916-a77d-88a00c16f6a5", "2ca8666e-7268-40fe-ab6b-aa584a4940b5", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fa1611b-a893-4a7e-aef6-7d4f7e6129e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6afd900f-ad18-4305-a362-f7e6b60119f8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da779c59-41d2-4916-a77d-88a00c16f6a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "07177f1b-bc15-411f-a06b-4c483797b52f", "9bbf9685-0b65-4ba1-b8aa-b4da4c46939f", "Admin", "ADMIN" });
        }
    }
}
