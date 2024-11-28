using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking wiht Joe!", new DateTime(2024, 11, 28, 11, 42, 38, 162, DateTimeKind.Local).AddTicks(9359), "Went hiking" },
                    { 2, "Went to Disneyland wiht Joe!", new DateTime(2024, 11, 28, 11, 42, 38, 162, DateTimeKind.Local).AddTicks(9656), "Went to Disneyland" },
                    { 3, "Went diving wiht Joe!", new DateTime(2024, 11, 28, 11, 42, 38, 162, DateTimeKind.Local).AddTicks(9660), "Went diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
