using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 18, 12, 1, 22, 557, DateTimeKind.Local).AddTicks(5539),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 15, 27, 17, 637, DateTimeKind.Local).AddTicks(3555));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 15, 27, 17, 637, DateTimeKind.Local).AddTicks(3555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 18, 12, 1, 22, 557, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1aa336f3-0f2e-4e3c-8dcb-f54348667785"),
                column: "ConcurrencyStamp",
                value: "153b292d-3b49-4c4f-a9bb-881e9b35fe49");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a167506-7583-450f-8568-2ce4f02c95ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "018daaad-84e1-487d-93f7-e99545ca6d63", "AQAAAAEAACcQAAAAEGkyvwMHJ+Yr1w3Em1dSv+whGYgnR5aHw/4ILiUpcQ5AE8LTA4BenLUINpNpac/AvQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 15, 27, 17, 667, DateTimeKind.Local).AddTicks(3534));
        }
    }
}
