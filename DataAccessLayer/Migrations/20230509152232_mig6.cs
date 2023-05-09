using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 9, 18, 22, 32, 370, DateTimeKind.Local).AddTicks(6319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 9, 18, 22, 32, 370, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CaloryPerUnit", "CategoryId", "Name", "UnitId" },
                values: new object[,]
                {
                    { 1, 75.0, 1, "Haşlanmış Yumurta", 3 },
                    { 2, 4.2000000000000002, 1, "Siyah Zeytin", 3 },
                    { 3, 6.0, 1, "Yeşil Zeytin", 3 },
                    { 4, 2.2999999999999998, 1, "Çilek Reçeli", 1 },
                    { 5, 2.7000000000000002, 1, "Vişne Reçeli", 1 },
                    { 6, 3.5, 1, "Pekmez", 1 },
                    { 7, 6.4000000000000004, 1, "Tahin", 1 },
                    { 8, 2.7000000000000002, 2, "Beyaz Peynir", 1 },
                    { 9, 3.5, 2, "Kaşar Peyniri", 1 },
                    { 10, 500.0, 2, "Süt", 2 },
                    { 11, 0.72999999999999998, 2, "Yoğurt", 1 },
                    { 12, 23.0, 3, "Domates", 3 },
                    { 13, 14.0, 3, "Salatalık", 3 },
                    { 14, 20.0, 3, "Carliston Biber", 3 },
                    { 15, 30.0, 3, "Köy Biberi", 3 },
                    { 16, 25.0, 3, "Kapya Biberi", 3 },
                    { 17, 45.0, 3, "Kırmızı Elma", 3 },
                    { 18, 50.0, 3, "Yeşil Elma", 3 },
                    { 19, 47.0, 3, "Portakal", 3 },
                    { 20, 40.0, 3, "Mandalina", 3 },
                    { 21, 1.3999999999999999, 3, "Kiraz", 3 },
                    { 22, 45.0, 3, "Karpuz", 4 },
                    { 23, 150.0, 4, "Tarhana Çorbası", 4 },
                    { 24, 140.0, 4, "Mercimek Çorbası", 4 },
                    { 25, 95.0, 4, "Ezogelin Çorbası", 4 },
                    { 26, 132.0, 4, "Tavuk Çorbası", 4 },
                    { 27, 200.0, 4, "Pirinç Pilavı", 4 },
                    { 28, 240.0, 4, "Bulgur Pilavı", 4 },
                    { 29, 265.0, 4, "Kuru Fasülye", 4 },
                    { 30, 160.0, 4, "Nohut", 4 },
                    { 31, 80.0, 4, "Pırasa", 4 },
                    { 32, 40.0, 4, "Brokoli", 4 },
                    { 33, 250.0, 5, "Cağ Kebap", 3 },
                    { 34, 400.0, 5, "Adana Kebap", 4 },
                    { 35, 380.0, 5, "Urfa Kebap", 4 },
                    { 36, 500.0, 5, "Şiş Köfte", 4 },
                    { 37, 280.0, 5, "Antrikot", 4 },
                    { 38, 300.0, 5, "Biftek", 4 },
                    { 39, 450.0, 5, "Pirzola", 4 },
                    { 40, 351.0, 6, "Hamburger", 4 },
                    { 41, 265.0, 6, "Orta Boy Pizza", 4 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CaloryPerUnit", "CategoryId", "Name", "UnitId" },
                values: new object[,]
                {
                    { 42, 355.0, 6, "Patates Kızartması", 4 },
                    { 43, 272.0, 6, "Tavuk Döner", 4 },
                    { 44, 391.0, 6, "Et Döner", 4 },
                    { 45, 15.0, 6, "Midye", 3 },
                    { 46, 202.0, 7, "Kazan Dibi", 4 },
                    { 47, 293.0, 7, "Sütlaç", 4 },
                    { 48, 288.0, 7, "Baklava", 4 },
                    { 49, 76.0, 8, "Beyaz Ekmek", 4 },
                    { 50, 220.0, 8, "Simit", 4 },
                    { 51, 288.0, 8, "Poğaça", 4 },
                    { 52, 6.2999999999999998, 9, "Kuru Meyve", 1 },
                    { 53, 3.6000000000000001, 9, "Leblebi", 1 },
                    { 54, 5.7999999999999998, 9, "Karışık Kureyemiş", 1 },
                    { 55, 484.0, 10, "Cola", 2 },
                    { 56, 360.0, 10, "Ayran", 2 },
                    { 57, 133.0, 10, "Enerji İçeceği", 3 },
                    { 58, 185.0, 10, "Bira", 3 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                column: "Name",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Name",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Name",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Name",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "Name",
                keyValue: 4);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "AddedFoods",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 9, 18, 22, 32, 370, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2023, 5, 9, 18, 16, 13, 440, DateTimeKind.Local).AddTicks(9095));
        }
    }
}
