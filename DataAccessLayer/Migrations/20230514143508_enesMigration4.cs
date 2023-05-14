using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class enesMigration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 17, 35, 7, 601, DateTimeKind.Local).AddTicks(5909),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 17, 33, 0, 315, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 17, 35, 7, 601, DateTimeKind.Local).AddTicks(2422),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 17, 33, 0, 315, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Password" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 35, 7, 601, DateTimeKind.Local).AddTicks(3395), "60FE74406E7F353ED979F350F2FBB6A2E8690A5FA7D1B0C32983D1D8B3F95F67" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 14, 17, 35, 7, 601, DateTimeKind.Local).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 5, 14, 17, 35, 7, 601, DateTimeKind.Local).AddTicks(6059));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 17, 33, 0, 315, DateTimeKind.Local).AddTicks(2957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 17, 35, 7, 601, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 14, 17, 33, 0, 315, DateTimeKind.Local).AddTicks(28),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 14, 17, 35, 7, 601, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreationDate", "Password" },
                values: new object[] { new DateTime(2023, 5, 14, 17, 33, 0, 315, DateTimeKind.Local).AddTicks(737), "3D0C5A25E8DC42F58761ED4C270F75B0D680F6D41784A0E8CAAA0D3B786854ED" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 14, 17, 33, 0, 315, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2023, 5, 14, 17, 33, 0, 315, DateTimeKind.Local).AddTicks(3128));
        }
    }
}
