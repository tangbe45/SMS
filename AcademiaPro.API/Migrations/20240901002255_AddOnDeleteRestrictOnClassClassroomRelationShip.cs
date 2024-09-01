using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    public partial class AddOnDeleteRestrictOnClassClassroomRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Classes_LevelId",
                schema: "sms_app",
                table: "Classrooms");

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2910), new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2922) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2924), new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2925), new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 4,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2926), new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 5,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2927), new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                schema: "sms_app",
                table: "Classes",
                keyColumn: "LevelId",
                keyValue: 6,
                columns: new[] { "CreatedAt", "LastModifiedAt" },
                values: new object[] { new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2928), new DateTime(2024, 9, 1, 1, 22, 54, 911, DateTimeKind.Local).AddTicks(2934) });

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Classes_LevelId",
                schema: "sms_app",
                table: "Classrooms",
                column: "LevelId",
                principalSchema: "sms_app",
                principalTable: "Classes",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Classes_LevelId",
                schema: "sms_app",
                table: "Classrooms");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Classrooms_Classes_LevelId",
                schema: "sms_app",
                table: "Classrooms",
                column: "LevelId",
                principalSchema: "sms_app",
                principalTable: "Classes",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
