using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodSite.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitailDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryPiece = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentName = table.Column<string>(type: "TEXT", nullable: true),
                    CommentMail = table.Column<string>(type: "TEXT", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    CommentDetails = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodName = table.Column<string>(type: "TEXT", nullable: true),
                    FoodRecipe = table.Column<string>(type: "TEXT", nullable: true),
                    FoodImage = table.Column<string>(type: "TEXT", nullable: true),
                    FoodPuan = table.Column<decimal>(type: "TEXT", nullable: false),
                    FoodUrl = table.Column<string>(type: "TEXT", nullable: true),
                    FoodDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FoodDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    FoodApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    FoodHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    FoodDetails = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaterialName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => new { x.FoodId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_FoodCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodCategories_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodComments",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodComments", x => new { x.FoodId, x.CommentId });
                    table.ForeignKey(
                        name: "FK_FoodComments_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodComments_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMaterials",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false),
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMaterials", x => new { x.FoodId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_FoodMaterials_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDeleted", "CategoryName", "CategoryPiece", "CategoryUrl" },
                values: new object[,]
                {
                    { 1, false, "Kahvaltılık", 0, "kahvaltilik" },
                    { 2, false, "Kek", 0, "kek" },
                    { 3, false, "Tatlı", 0, "tatli" },
                    { 4, false, "Börek", 0, "borek" },
                    { 5, false, "Çorba", 0, "corba" },
                    { 6, false, "Makarna", 0, "makarna" }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "CommentId", "CommentApproved", "CommentDate", "CommentDetails", "CommentMail", "CommentName" },
                values: new object[,]
                {
                    { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harika bir kahvaltılık herkese öneririm", "muhammetcukur@gmail.com", "Muhammet Çukur" },
                    { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harika bir kek tarifi herkese öneririm", "haticebayram@gmail.com", "Hatice Bayram" },
                    { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harika bir tatlı tarifi herkese öneririm", "bilalcukur@gmail.com", "Bilal Çukur" },
                    { 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harika bir börek tarifi herkese öneririm", "haruncukur@gmail.com", "Harun Çukur" },
                    { 5, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harika bir çorba tarifi herkese öneririm", "salihacukur@gmail.com", "Saliha Çukur" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodId", "FoodApproved", "FoodDate", "FoodDeleted", "FoodDetails", "FoodHome", "FoodImage", "FoodName", "FoodPuan", "FoodRecipe", "FoodUrl" },
                values: new object[,]
                {
                    { 1, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, true, "firinda-peynirli-ekmek.jpg", "Fırında Peynirli Ekmek", 9m, "Bir kasede rendelenmiş peynirleri, yumurta, nane, pul biber, maydanoz ve zeytinyağı ile birlikte karıştırın.", "firinda-peynirli-ekmek" },
                    { 2, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, true, "damla-cikolatali-kek.jpg", "Damla Çikolatalı Kek", 8m, "Kek kalıbınızı tereyağı ile yağladıktan sonra buzdolabında 5 dakika kadar bekletirseniz pişme sonucunda kekiniz kalıptan rahatça çıkacaktır. Kakaolu keklerde kakao, sade un kullandığınız keklerde kalıba tereyağından sonra un serperseniz yine kalıptan çıkmasını kolaylaştırırsınız. Un ekledikten sonra çırpıcı ile değil spatula yada çırpma teli ile sadece karışana kadar çırpmanız kekinizin güzel kabarmasını sağlar. Unu elemeniz de daha çok kabarmasını sağlar.", "damla-cikolatali-kek" },
                    { 3, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, true, "sultan-sarmasi.jpg", "Sultan Sarması", 9m, "Bir tencerede un, toz şeker ve kakaoyu karıştırıp, üzerine yavaşça süt ilave edip sürekli karıştırarak orta ateşte pişirin.", "sultan-sarmasi" },
                    { 4, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, true, "avci-boregi.jpg", "Avcı Böreği", 9m, "Fırında pişirme ya da kızartma esnasında dağılmaması için börekleri çok fazla iç harçla doldurmamaya ve gevşek bir şekilde sarmamaya özen gösterin.Böreklerin her tarafını çırpılmış yumurta ve galeta ununa bulayın.", "avci-boregi" },
                    { 5, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, true, "mercimek-corbasi.jpg", "Mercimek Çorbası", 9m, "Zeytinyağını koyduğunuz tencereyi orta-kısık ateşe alarak ısıtın.Soğanı rendeleyin veya küp küp doğrağın, tencereye ekleyerek hafifçe kavurmaya başlayın.", "mercimek-corbasi" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "MaterialName" },
                values: new object[,]
                {
                    { 1, "Ayçiçek Yağı" },
                    { 2, "Kuru Soğan" },
                    { 3, "Un" },
                    { 4, "Havuç" },
                    { 5, "Patates" },
                    { 6, "Tuz" },
                    { 7, "Karabiber" },
                    { 8, "Kırmızı Mercimek" },
                    { 9, "Sarı Mercimek" },
                    { 10, "Su" },
                    { 11, "Tereyağ" },
                    { 12, "Kırmızı Toz Biber" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "FoodMaterials",
                columns: new[] { "FoodId", "MaterialId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_CategoryId",
                table: "FoodCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodComments_CommentId",
                table: "FoodComments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMaterials_MaterialId",
                table: "FoodMaterials",
                column: "MaterialId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "FoodComments");

            migrationBuilder.DropTable(
                name: "FoodMaterials");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Materials");
        }
    }
}
