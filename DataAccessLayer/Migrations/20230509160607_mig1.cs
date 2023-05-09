using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LifeStyles",
                columns: table => new
                {
                    Type = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActivityLevel = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LifeStyles", x => x.Type);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Name = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    Name = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    SpecificQuestion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuestionAnswer = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ActivePassiveSituation = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    LifeStyleId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 9, 19, 6, 7, 221, DateTimeKind.Local).AddTicks(5484))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_LifeStyles_LifeStyleId",
                        column: x => x.LifeStyleId,
                        principalTable: "LifeStyles",
                        principalColumn: "Type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CaloryPerUnit = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Foods_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddedFoods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    TotalCalory = table.Column<double>(type: "float", nullable: false),
                    TargetCaloryPerDay = table.Column<double>(type: "float", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 9, 19, 6, 7, 220, DateTimeKind.Local).AddTicks(9382)),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddedFoods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddedFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddedFoods_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddedFoods_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreationDate", "Email", "Password" },
                values: new object[] { 1, new DateTime(2023, 5, 9, 19, 6, 7, 221, DateTimeKind.Local).AddTicks(1063), "admin@admin.com", "Admin1234" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Kahvaltılık" },
                    { 2, "Süt ve Süt Ürünleri" },
                    { 3, "Meyve ve Sebze" },
                    { 4, "Ev Yemekleri" },
                    { 5, "Et Yemekleri" },
                    { 6, "Fast Food" },
                    { 7, "Tatlı" },
                    { 8, "Fırın" },
                    { 9, "Atıştırmalık" },
                    { 10, "İçecekler" }
                });

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
                    { 41, 265.0, 6, "Orta Boy Pizza", 4 },
                    { 42, 355.0, 6, "Patates Kızartması", 4 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CaloryPerUnit", "CategoryId", "Name", "UnitId" },
                values: new object[,]
                {
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
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreationDate", "Email", "Gender", "Height", "LifeStyleId", "Name", "Password", "QuestionAnswer", "SpecificQuestion", "Surname", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 19, 6, 7, 221, DateTimeKind.Local).AddTicks(5621), "ahmetyilmaz@yilmaz.com", 2, 1.8200000000000001, 2, "Ahmet", "AaBb12.,", "C#", "En Sevdiğin Programlama Dili?", "Yılmaz", 103.0 },
                    { 2, new DateTime(1997, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 9, 19, 6, 7, 221, DateTimeKind.Local).AddTicks(5800), "ayşesevgi@sevgi.com", 1, 1.55, 3, "Ayşe", "AaBb12.,", "Java", "En Sevdiğin Programlama Dili?", "Sevgi", 55.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddedFoods_FoodId",
                table: "AddedFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_AddedFoods_MealId",
                table: "AddedFoods",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_AddedFoods_UserId",
                table: "AddedFoods",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Admins_Email",
                table: "Admins",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_UnitId",
                table: "Foods",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_LifeStyleId",
                table: "Users",
                column: "LifeStyleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddedFoods");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "LifeStyles");
        }
    }
}
