using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 15, 27, 17, 637, DateTimeKind.Local).AddTicks(3555),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 9, 42, 24, 123, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 11, 17, 9, 42, 24, 123, DateTimeKind.Local).AddTicks(9010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 11, 17, 15, 27, 17, 637, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("1aa336f3-0f2e-4e3c-8dcb-f54348667785"),
                column: "ConcurrencyStamp",
                value: "7c0ee9ae-b86e-4ce6-9c6e-7713aa4eac60");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8a167506-7583-450f-8568-2ce4f02c95ac"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bee57db-2ed4-48bd-8442-e98d14f89464", "AQAAAAEAACcQAAAAEEFnak21SUZoPzPV8FQUsDGuLm1I1hqbSy167HmBmbybqNpgwgu3duovKNk7GNqBsg==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 11, 17, 9, 42, 24, 142, DateTimeKind.Local).AddTicks(8222));
        }
    }
}
