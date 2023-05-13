using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class enesMigration : Migration
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
                name: "Goals",
                columns: table => new
                {
                    GoalType = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goals", x => x.GoalType);
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
                    GoalTypeId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 13, 19, 53, 21, 198, DateTimeKind.Local).AddTicks(913))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Goals_GoalTypeId",
                        column: x => x.GoalTypeId,
                        principalTable: "Goals",
                        principalColumn: "GoalType",
                        onDelete: ReferentialAction.Cascade);
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
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 13, 19, 53, 21, 197, DateTimeKind.Local).AddTicks(7962)),
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
                values: new object[] { 1, new DateTime(2023, 5, 13, 19, 53, 21, 197, DateTimeKind.Local).AddTicks(8690), "admin@admin.com", "Admin1234" });

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
                table: "Goals",
                columns: new[] { "GoalType", "Description" },
                values: new object[,]
                {
                    { 1, "Kilo vermek istiyorum." },
                    { 2, "Dengeli bir şekilde kilo almak istiyorum." },
                    { 3, "Hızlı ve sağlıklı bir şekilde kilo almalıyım." },
                    { 4, "Mevcut kilomu korumak istiyorum" }
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
                columns: new[] { "Id", "CaloryPerUnit", "CategoryId", "Image", "Name", "UnitId" },
                values: new object[,]
                {
                    { 1, 75.0, 1, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=1 Yumurta.png", "Haşlanmış Yumurta", 3 },
                    { 2, 4.2000000000000002, 1, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=2 siyah zeytin.png", "Siyah Zeytin", 3 },
                    { 3, 6.0, 1, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=3 yeşil zeytin.jpg", "Yeşil Zeytin", 3 },
                    { 4, 2.2999999999999998, 1, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=4 çilek reçeli2.jpg", "Çilek Reçeli", 1 },
                    { 5, 2.7000000000000002, 1, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=5 vişne reçeli.png", "Vişne Reçeli", 1 },
                    { 6, 3.5, 1, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=6 pekmez.jpg", "Pekmez", 1 },
                    { 7, 6.4000000000000004, 1, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=7 tahin.png", "Tahin", 1 },
                    { 8, 2.7000000000000002, 2, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=8 beyaz peynir.png", "Beyaz Peynir", 1 },
                    { 9, 3.5, 2, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=9 kasar peynir.png", "Kaşar Peyniri", 1 },
                    { 10, 500.0, 2, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=10 süt.jpg", "Süt", 2 },
                    { 11, 0.72999999999999998, 2, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=11 yoğurt.png", "Yoğurt", 1 },
                    { 12, 23.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=12 domates.jpeg", "Domates", 3 },
                    { 13, 14.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=13 salatalık.jpg", "Salatalık", 3 },
                    { 14, 20.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=14 biber.jpg", "Carliston Biber", 3 },
                    { 15, 30.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=15 köy biberi.png", "Köy Biberi", 3 },
                    { 16, 25.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=16 kapya biber.png", "Kapya Biberi", 3 },
                    { 17, 45.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=17 kırmızı elma.jpg", "Kırmızı Elma", 3 },
                    { 18, 50.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=18 yeşil elma.jpg", "Yeşil Elma", 3 },
                    { 19, 47.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=19 portakal.jpg", "Portakal", 3 },
                    { 20, 40.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=20 mandalina.jpg", "Mandalina", 3 },
                    { 21, 1.3999999999999999, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=21 kiraz.jpg", "Kiraz", 3 },
                    { 22, 45.0, 3, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=22 karpuz.jpg", "Karpuz", 4 },
                    { 23, 150.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=23 tarhana çorbası.png", "Tarhana Çorbası", 4 },
                    { 24, 140.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=24 mercimek çorbası.png", "Mercimek Çorbası", 4 },
                    { 25, 95.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=25 ezogelin çorbası.png", "Ezogelin Çorbası", 4 },
                    { 26, 132.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=26 tavuk çorbası.png", "Tavuk Çorbası", 4 },
                    { 27, 200.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=27 pirinç pilavı.png", "Pirinç Pilavı", 4 },
                    { 28, 240.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=28 bulgur pilavı.png", "Bulgur Pilavı", 4 },
                    { 29, 265.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=29 kuru fasülye.png", "Kuru Fasülye", 4 },
                    { 30, 160.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=30 kuru fasülye.png", "Nohut", 4 },
                    { 31, 80.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=31 pırasa yemeği.png", "Pırasa", 4 },
                    { 32, 40.0, 4, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=32 brokoli yemeği.png", "Brokoli", 4 },
                    { 33, 250.0, 5, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=33 cağ kebap.png", "Cağ Kebap", 3 },
                    { 34, 400.0, 5, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=34 adana kebap.png", "Adana Kebap", 4 },
                    { 35, 380.0, 5, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=35 urfa kebap.png", "Urfa Kebap", 4 },
                    { 36, 500.0, 5, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=36 şiş köfte.png", "Şiş Köfte", 4 },
                    { 37, 280.0, 5, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=37 antrikot.jpg", "Antrikot", 4 },
                    { 38, 300.0, 5, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=38 biftek.jpeg", "Biftek", 4 },
                    { 39, 450.0, 5, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=39 pirzola.png", "Pirzola", 4 },
                    { 40, 351.0, 6, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=40 hamburger.png", "Hamburger", 4 },
                    { 41, 265.0, 6, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=41 pizza.png", "Orta Boy Pizza", 4 },
                    { 42, 355.0, 6, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=42 patates kızartması.png", "Patates Kızartması", 4 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CaloryPerUnit", "CategoryId", "Image", "Name", "UnitId" },
                values: new object[,]
                {
                    { 43, 272.0, 6, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=43 tavuk döner.png", "Tavuk Döner", 4 },
                    { 44, 391.0, 6, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=44 et döner.png", "Et Döner", 4 },
                    { 45, 15.0, 6, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=45 midye.png", "Midye", 3 },
                    { 46, 202.0, 7, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=46 kazandibi.png", "Kazan Dibi", 4 },
                    { 47, 293.0, 7, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=47 sütlaç.png", "Sütlaç", 4 },
                    { 48, 288.0, 7, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=48 baklava.png", "Baklava", 4 },
                    { 49, 76.0, 8, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=49 beyaz ekmek.png", "Beyaz Ekmek", 4 },
                    { 50, 220.0, 8, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=50 simit.png", "Simit", 4 },
                    { 51, 288.0, 8, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=51 poğaça.jpg", "Poğaça", 4 },
                    { 52, 6.2999999999999998, 9, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=52 Kuru Meyve.png", "Kuru Meyve", 1 },
                    { 53, 3.6000000000000001, 9, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=53 Leblebi.png", "Leblebi", 1 },
                    { 54, 5.7999999999999998, 9, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=54 Karışık Kuruyemiş.png", "Karışık Kureyemiş", 1 },
                    { 55, 484.0, 10, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=55 Kola.png", "Cola", 2 },
                    { 56, 360.0, 10, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=56 Ayran.png", "Ayran", 2 },
                    { 57, 133.0, 10, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=57 enerji içeceği.png", "Enerji İçeceği", 3 },
                    { 58, 185.0, 10, "C:\\Users\\nskar\\source\\repos\\Team4MidtermProject\\DataAccessLayer\\Pictures\\Id=58 bira.png", "Bira", 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreationDate", "Email", "Gender", "GoalTypeId", "Height", "LifeStyleId", "Name", "Password", "QuestionAnswer", "SpecificQuestion", "Surname", "Weight" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 19, 53, 21, 198, DateTimeKind.Local).AddTicks(979), "ahmetyilmaz@yilmaz.com", 2, 1, 182.0, 2, "AHMET", "AaBb12.,", "C#", "En Sevdiğin Programlama Dili?", "YILMAZ", 113.0 },
                    { 2, new DateTime(1997, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 13, 19, 53, 21, 198, DateTimeKind.Local).AddTicks(1054), "ayşesevgi@sevgi.com", 1, 3, 185.0, 3, "AYŞE", "AaBb12.,", "JAVA", "En Sevdiğin Programlama Dili?", "SEVGİ", 55.0 }
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
                name: "IX_Users_GoalTypeId",
                table: "Users",
                column: "GoalTypeId");

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
                name: "Goals");

            migrationBuilder.DropTable(
                name: "LifeStyles");
        }
    }
}
