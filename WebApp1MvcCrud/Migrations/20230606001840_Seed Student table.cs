using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp1MvcCrud.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudenttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Grade",
                table: "Students",
                type: "real",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Firstname", "Grade", "Lastname", "RegDate" },
                values: new object[,]
                {
                    { 1, (short)18, "Patricia", 3.1f, "White", new DateTime(2023, 6, 5, 20, 18, 40, 86, DateTimeKind.Local).AddTicks(5680) },
                    { 2, (short)21, "Alejandra", 2.85f, "Ferguson", new DateTime(2023, 6, 5, 20, 18, 40, 86, DateTimeKind.Local).AddTicks(5743) },
                    { 3, (short)22, "Bonnie", 2.31f, "Kingsley", new DateTime(2023, 6, 5, 20, 18, 40, 86, DateTimeKind.Local).AddTicks(5747) },
                    { 4, (short)17, "Michelle", 3.22f, "Pate", new DateTime(2023, 6, 5, 20, 18, 40, 86, DateTimeKind.Local).AddTicks(5751) },
                    { 5, (short)24, "Shirley ", 3.38f, "Krug", new DateTime(2023, 6, 5, 20, 18, 40, 86, DateTimeKind.Local).AddTicks(5755) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<short>(
                name: "Grade",
                table: "Students",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
