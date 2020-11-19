using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class RemoveProductSeoAlias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeoAlias",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 19, 13, 16, 1, 549, DateTimeKind.Local).AddTicks(2204),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 18, 12, 1, 22, 557, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1aa336f3-0f2e-4e3c-8dcb-f54348667785"),
                column: "ConcurrencyStamp",
                value: "a320f2b8-9c44-4fe0-ab77-766271b2e8d7");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a167506-7583-450f-8568-2ce4f02c95ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "785d2862-3011-4419-831b-7a79599f47dc", "AQAAAAEAACcQAAAAEJwYTf+A8ewQeBBDKnXrt4xhlwKNMwmQ+doXwiYmv4AZl3Ncqas8gEPJ6PpS+LjI1A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 19, 13, 16, 1, 573, DateTimeKind.Local).AddTicks(4803));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeoAlias",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 18, 12, 1, 22, 557, DateTimeKind.Local).AddTicks(5539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 19, 13, 16, 1, 549, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1aa336f3-0f2e-4e3c-8dcb-f54348667785"),
                column: "ConcurrencyStamp",
                value: "6218977a-c8a4-4236-94e6-3a1142727cd9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a167506-7583-450f-8568-2ce4f02c95ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d3335de-76e6-4c4a-b759-8c9bf116d6b9", "AQAAAAEAACcQAAAAECJxToExACGhL+KbeoI2Wg1JwUCt8kSfcMBZCbmwvXoU4yq56aCXGzXJfX6WemT7kw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 18, 12, 1, 22, 585, DateTimeKind.Local).AddTicks(2327));
        }
    }
}
