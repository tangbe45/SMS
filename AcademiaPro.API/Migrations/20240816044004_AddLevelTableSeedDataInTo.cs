using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    public partial class AddLevelTableSeedDataInTo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sms_app");

            migrationBuilder.CreateTable(
                name: "Classes",
                schema: "sms_app",
                columns: table => new
                {
                    LevelId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    SortOrder = table.Column<byte>(type: "smallint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.LevelId);
                });

            migrationBuilder.InsertData(
                schema: "sms_app",
                table: "Classes",
                columns: new[] { "LevelId", "CreatedAt", "LastModifiedAt", "Name", "SortOrder" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6432), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6445), "Class 1", (byte)1 },
                    { 2, new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6447), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6448), "Class 2", (byte)2 },
                    { 3, new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6449), "Class 3", (byte)3 },
                    { 4, new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6450), "Class 4", (byte)4 },
                    { 5, new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6452), "Class 5", (byte)5 },
                    { 6, new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6460), "Class 6", (byte)6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_Name",
                schema: "sms_app",
                table: "Classes",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes",
                schema: "sms_app");
        }
    }
}
