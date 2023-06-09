using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp1MvcCrud.Migrations
{
    /// <inheritdoc />
    public partial class columnNamesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<short>(type: "smallint", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grade = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "FirstName", "Grade", "LastName", "RegDate" },
                values: new object[,]
                {
                    { new Guid("06b8f4cf-bef7-4152-bc78-b78f97c74e09"), (short)22, "Bonnie", 2.31f, "Kingsley", new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2966) },
                    { new Guid("4106915c-e7f3-4b93-955f-f740e406bc96"), (short)24, "Shirley ", 3.38f, "Krug", new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2984) },
                    { new Guid("81a0fe29-be21-411d-a4c4-b0dd503fbdd4"), (short)17, "Michelle", 3.22f, "Pate", new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2969) },
                    { new Guid("aad3ff5a-82e3-457d-a2eb-0d94ce9019d8"), (short)21, "Alejandra", 2.85f, "Ferguson", new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2961) },
                    { new Guid("d0176b50-d177-4be2-97d9-565dc9f3b2a3"), (short)18, "Patricia", 3.1f, "White", new DateTime(2023, 6, 8, 13, 30, 11, 417, DateTimeKind.Local).AddTicks(2917) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
