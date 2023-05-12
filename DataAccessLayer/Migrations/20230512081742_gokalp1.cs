using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class gokalp1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 11, 17, 42, 283, DateTimeKind.Local).AddTicks(4850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 11, 17, 7, 179, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 11, 17, 42, 283, DateTimeKind.Local).AddTicks(280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 11, 17, 7, 179, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 11, 17, 42, 283, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 11, 17, 42, 283, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 11, 17, 42, 283, DateTimeKind.Local).AddTicks(5024));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 11, 17, 7, 179, DateTimeKind.Local).AddTicks(6905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 11, 17, 42, 283, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 11, 17, 7, 179, DateTimeKind.Local).AddTicks(2531),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 11, 17, 42, 283, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 11, 17, 7, 179, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 11, 17, 7, 179, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 11, 17, 7, 179, DateTimeKind.Local).AddTicks(7087));
        }
    }
}
