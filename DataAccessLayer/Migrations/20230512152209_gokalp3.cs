using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class gokalp3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 22, 8, 488, DateTimeKind.Local).AddTicks(842),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 18, 22, 8, 487, DateTimeKind.Local).AddTicks(6918),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 15, 42, 47, 312, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 18, 22, 8, 487, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Name", "Surname" },
                values: new object[] { new DateTime(2023, 5, 12, 18, 22, 8, 488, DateTimeKind.Local).AddTicks(949), "AHMET", "YILMAZ" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Name", "QuestionAnswer", "Surname" },
                values: new object[] { new DateTime(2023, 5, 12, 18, 22, 8, 488, DateTimeKind.Local).AddTicks(1016), "AYŞE", "JAVA", "SEVGİ" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 22, 8, 488, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 15, 42, 47, 312, DateTimeKind.Local).AddTicks(7969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 18, 22, 8, 487, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 15, 42, 47, 312, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Name", "Surname" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2182), "Ahmet", "Yılmaz" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Name", "QuestionAnswer", "Surname" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2252), "Ayşe", "Java", "Sevgi" });
        }
    }
}
