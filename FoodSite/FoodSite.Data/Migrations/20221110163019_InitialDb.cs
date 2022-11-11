using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodSite.Data.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentContent = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Point = table.Column<decimal>(type: "TEXT", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Point = table.Column<decimal>(type: "TEXT", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Recipe = table.Column<string>(type: "TEXT", nullable: true),
                    Properties = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Point = table.Column<decimal>(type: "TEXT", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductComments",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComments", x => new { x.ProductId, x.CommentId });
                    table.ForeignKey(
                        name: "FK_ProductComments_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductComments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMaterials",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMaterials", x => new { x.ProductId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_ProductMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMaterials_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[] { 1, "Atıştırmalık", "Atıştırmalık", "cigkofte" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[] { 2, "Başlangıç Tabağı", "Çorba", "corba" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[] { 3, "Kahvaltı Tabağı", "Kahvaltı", "kahvalti" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[] { 4, "Tatlı Tabağı", "Tatlı", "tatli" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[] { 5, "Hamur içi", "Börek", "borek" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Ayçiçek Yağı", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Kuru Soğan", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Un", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Havuç", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Patates", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Tuz", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Karabiber", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Kırmızı Mercimek", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Sarı Mercimek", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Su", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Tereyağ", 0m, null });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Url" },
                values: new object[] { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, false, false, null, "Kırmızı Toz Biber", 0m, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Properties", "Recipe", "Url" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mercimek-corbasi.jpg", true, false, true, null, "Mercimek Çorbası", 0m, "Çorba", null, "mercimek-corbasi" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Properties", "Recipe", "Url" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ezogelin-corbasi.jpg", true, false, true, null, "Egogelin Çorbası", 0m, "Çorba", null, "ezogelin-corbasi" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Properties", "Recipe", "Url" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "cig-kofte.jpeg", true, false, true, null, "Çiğ Köfte", 0m, "Atıştırmalık", null, "cig-kofte" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Date", "ImageUrl", "IsApproved", "IsDeleted", "IsHome", "Mail", "Name", "Point", "Properties", "Recipe", "Url" },
                values: new object[] { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kiymali-borek.jpg", true, false, true, null, "Patatesli Sigara Böreği", 0m, "Atıştırmalık", null, "kiymali-sigara-boregi" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 5, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 8, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 9, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 10, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 11, 1 });

            migrationBuilder.InsertData(
                table: "ProductMaterials",
                columns: new[] { "MaterialId", "ProductId" },
                values: new object[] { 12, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_CommentId",
                table: "ProductComments",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMaterials_MaterialId",
                table: "ProductMaterials",
                column: "MaterialId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "ProductComments");

            migrationBuilder.DropTable(
                name: "ProductMaterials");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
