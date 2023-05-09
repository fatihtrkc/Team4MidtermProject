using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 9, 18, 16, 13, 440, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.InsertData(
                table: "LifeStyles",
                columns: new[] { "Type", "ActivityLevel", "Description" },
                values: new object[,]
                {
                    { 1, 0.0, "Haraket etmiyorum veya çok az hareket ediyorum" },
                    { 2, 0.0, "Haftada 1-3 gün egzersiz yapıyorum" },
                    { 3, 0.0, "Haftada 3-5 gün egzersiz yapıyorum" },
                    { 4, 0.0, "Haftada 6-7 gün egzersiz yapıyorum" },
                    { 5, 0.0, "Profesyonel sporcu, atlet seviyesi" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LifeStyles",
                keyColumn: "Type",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LifeStyles",
                keyColumn: "Type",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LifeStyles",
                keyColumn: "Type",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LifeStyles",
                keyColumn: "Type",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LifeStyles",
                keyColumn: "Type",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 9, 18, 15, 46, 48, DateTimeKind.Local).AddTicks(7066));
        }
    }
}
