using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    public partial class ChangeMigrationsHistorySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8229) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8232), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8233) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8236), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8237) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8256) });
        }
    }
}
