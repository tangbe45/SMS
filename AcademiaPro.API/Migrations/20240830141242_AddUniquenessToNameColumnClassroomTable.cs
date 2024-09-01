using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    public partial class AddUniquenessToNameColumnClassroomTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7519), new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7539), new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7541), new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7544), new DateTime(2024, 8, 30, 15, 12, 42, 284, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.CreateIndex(
                name: "IX_Classrooms_Name",
                schema: "sms_app",
                table: "Classrooms",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Classrooms_Name",
                schema: "sms_app",
                table: "Classrooms");

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5044), new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5096), new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5100), new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5102), new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5104), new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5106), new DateTime(2024, 8, 29, 17, 39, 46, 40, DateTimeKind.Local).AddTicks(5124) });
        }
    }
}
