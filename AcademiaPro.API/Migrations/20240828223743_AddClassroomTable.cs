using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    public partial class AddClassroomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classroom",
                schema: "sms_app",
                columns: table => new
                {
                    ClassroomId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Capacity = table.Column<int>(type: "integer", nullable: false),
                    StudentCount = table.Column<int>(type: "integer", nullable: false),
                    LevelId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classroom", x => x.ClassroomId);
                    table.ForeignKey(
                        name: "FK_Classroom_Classes_LevelId",
                        column: x => x.LevelId,
                        principalSchema: "sms_app",
                        principalTable: "Classes",
                        principalColumn: "LevelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4315), new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4333), new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4334), new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4335), new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4336), new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4337), new DateTime(2024, 8, 28, 23, 37, 43, 262, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.CreateIndex(
                name: "IX_Classroom_LevelId",
                schema: "sms_app",
                table: "Classroom",
                column: "LevelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classroom",
                schema: "sms_app");

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8546), new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8567), new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8568), new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8569) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8574), new DateTime(2024, 8, 21, 12, 39, 0, 825, DateTimeKind.Local).AddTicks(8574) });
        }
    }
}
