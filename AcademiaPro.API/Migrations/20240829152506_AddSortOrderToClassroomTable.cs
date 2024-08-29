using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    public partial class AddSortOrderToClassroomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                schema: "sms_app",
                table: "Classroom",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 8, 29, 16, 25, 6, 124, DateTimeKind.Local).AddTicks(4787) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                schema: "sms_app",
                table: "Classroom");

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
        }
    }
}
