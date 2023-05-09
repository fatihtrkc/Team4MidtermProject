using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 9, 18, 15, 46, 48, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Name", "Description" },
                values: new object[,]
                {
                    { 1, "1 gram" },
                    { 2, "1000 mililitre" },
                    { 3, "1 tane" },
                    { 4, "1 tabak / 1 dilim / Tam" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Name",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Name",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Name",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Name",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 9, 18, 15, 16, 855, DateTimeKind.Local).AddTicks(76));
        }
    }
}
