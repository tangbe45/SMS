using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    public partial class ChangeSortOrderTypeFromByteToInteger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SortOrder",
                schema: "sms_app",
                table: "Classes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8193), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8229), 1 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8232), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8233), 2 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8234), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8235), 3 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8236), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8237), 4 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8240), 5 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 8, 19, 16, 52, 49, 66, DateTimeKind.Local).AddTicks(8256), 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "SortOrder",
                schema: "sms_app",
                table: "Classes",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6432), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6445), (byte)1 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6447), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6448), (byte)2 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6449), (byte)3 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6450), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6450), (byte)4 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6452), (byte)5 });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt", "SortOrder" },
                values: new object[] { new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 8, 16, 5, 40, 4, 325, DateTimeKind.Local).AddTicks(6460), (byte)6 });
        }
    }
}
