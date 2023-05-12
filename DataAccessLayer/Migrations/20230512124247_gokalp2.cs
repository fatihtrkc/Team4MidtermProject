using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class gokalp2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2063),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 12, 55, 11, 857, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 15, 42, 47, 312, DateTimeKind.Local).AddTicks(7969),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 12, 55, 11, 856, DateTimeKind.Local).AddTicks(6731));

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
                columns: new[] { "CreationDate", "Height" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2182), 182.0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Height" },
                values: new object[] { new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2252), 185.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 12, 55, 11, 857, DateTimeKind.Local).AddTicks(6334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 15, 42, 47, 313, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 12, 12, 55, 11, 856, DateTimeKind.Local).AddTicks(6731),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 12, 15, 42, 47, 312, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 12, 12, 55, 11, 856, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Height" },
                values: new object[] { new DateTime(2023, 5, 12, 12, 55, 11, 857, DateTimeKind.Local).AddTicks(6627), 1.8200000000000001 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreationDate", "Height" },
                values: new object[] { new DateTime(2023, 5, 12, 12, 55, 11, 857, DateTimeKind.Local).AddTicks(6713), 1.8500000000000001 });
        }
    }
}
