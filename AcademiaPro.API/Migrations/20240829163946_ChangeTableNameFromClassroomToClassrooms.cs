using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AcademiaPro.API.Migrations
{
    public partial class ChangeTableNameFromClassroomToClassrooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classroom_Classes_LevelId",
                schema: "sms_app",
                table: "Classroom");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classroom",
                schema: "sms_app",
                table: "Classroom");

            migrationBuilder.RenameTable(
                name: "Classroom",
                schema: "sms_app",
                newName: "Classrooms",
                newSchema: "sms_app");

            migrationBuilder.RenameIndex(
                name: "IX_Classroom_LevelId",
                schema: "sms_app",
                table: "Classrooms",
                newName: "IX_Classrooms_LevelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classrooms",
                schema: "sms_app",
                table: "Classrooms",
                column: "ClassroomId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classrooms_Classes_LevelId",
                schema: "sms_app",
                table: "Classrooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classrooms",
                schema: "sms_app",
                table: "Classrooms");

            migrationBuilder.RenameTable(
                name: "Classrooms",
                schema: "sms_app",
                newName: "Classroom",
                newSchema: "sms_app");

            migrationBuilder.RenameIndex(
                name: "IX_Classrooms_LevelId",
                schema: "sms_app",
                table: "Classroom",
                newName: "IX_Classroom_LevelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classroom",
                schema: "sms_app",
                table: "Classroom",
                column: "ClassroomId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Classroom_Classes_LevelId",
                schema: "sms_app",
                table: "Classroom",
                column: "LevelId",
                principalSchema: "sms_app",
                principalTable: "Classes",
                principalColumn: "LevelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
