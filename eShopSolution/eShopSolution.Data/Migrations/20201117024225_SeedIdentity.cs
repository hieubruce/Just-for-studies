using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 9, 42, 24, 123, DateTimeKind.Local).AddTicks(9010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 9, 32, 38, 860, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("1aa336f3-0f2e-4e3c-8dcb-f54348667785"), "7c0ee9ae-b86e-4ce6-9c6e-7713aa4eac60", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("1aa336f3-0f2e-4e3c-8dcb-f54348667785"), new Guid("8a167506-7583-450f-8568-2ce4f02c95ac") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("8a167506-7583-450f-8568-2ce4f02c95ac"), 0, "3bee57db-2ed4-48bd-8442-e98d14f89464", new DateTime(2020, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hieubruce123@gmail.com", true, "Hieu", "Nguyen", false, null, "hieubruce123@gmail.com", "admin", "AQAAAAEAACcQAAAAEEFnak21SUZoPzPV8FQUsDGuLm1I1hqbSy167HmBmbybqNpgwgu3duovKNk7GNqBsg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 9, 42, 24, 142, DateTimeKind.Local).AddTicks(8222));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1aa336f3-0f2e-4e3c-8dcb-f54348667785"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("1aa336f3-0f2e-4e3c-8dcb-f54348667785"), new Guid("8a167506-7583-450f-8568-2ce4f02c95ac") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a167506-7583-450f-8568-2ce4f02c95ac"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 9, 32, 38, 860, DateTimeKind.Local).AddTicks(198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 9, 42, 24, 123, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 9, 32, 38, 884, DateTimeKind.Local).AddTicks(5265));
        }
    }
}
