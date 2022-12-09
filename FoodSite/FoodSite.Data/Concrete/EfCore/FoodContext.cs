using FoodSite.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Data.Concrete.EfCore
{
    public class FoodContext : DbContext
    {
        public FoodContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<FoodComment> FoodComments { get; set; }
        public DbSet<FoodMaterial> FoodMaterials { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<FoodCategory>()
                .HasKey(fc => new
                {
                    fc.FoodId,
                    fc.CategoryId
                });
            modelBuilder
                .Entity<FoodComment>()
                .HasKey(fcm => new
                {
                    fcm.FoodId,
                    fcm.CommentId
                });
            modelBuilder
                .Entity<FoodMaterial>()
                .HasKey(fm => new
                {
                    fm.FoodId,
                    fm.MaterialId
                });
            modelBuilder
                .Entity<Category>()
                .HasData(
                new Category() { CategoryId = 1, CategoryName = "Kahvaltılık", CategoryUrl = "kahvaltilik" },
                new Category() { CategoryId = 2, CategoryName = "Kek", CategoryUrl = "kek" },
                new Category() { CategoryId = 3, CategoryName = "Tatlı", CategoryUrl = "tatli" },
                new Category() { CategoryId = 4, CategoryName = "Börek", CategoryUrl = "borek" },
                new Category() { CategoryId = 5, CategoryName = "Çorba", CategoryUrl = "corba" },
                new Category() { CategoryId = 6, CategoryName = "Makarna", CategoryUrl = "makarna" }
                );
            modelBuilder
                .Entity<Comment>()
                .HasData(
                new Comment { CommentId = 1, CommentName = "Muhammet Çukur", CommentMail = "muhammetcukur@gmail.com", CommentDetails = "Harika bir kahvaltılık herkese öneririm", CommentApproved = true },
                new Comment { CommentId = 2, CommentName = "Hatice Bayram", CommentMail = "haticebayram@gmail.com", CommentDetails = "Harika bir kek tarifi herkese öneririm", CommentApproved = true },
                new Comment { CommentId = 3, CommentName = "Bilal Çukur", CommentMail = "bilalcukur@gmail.com", CommentDetails = "Harika bir tatlı tarifi herkese öneririm", CommentApproved = true },
                new Comment { CommentId = 4, CommentName = "Harun Çukur", CommentMail = "haruncukur@gmail.com", CommentDetails = "Harika bir börek tarifi herkese öneririm", CommentApproved = true },
                new Comment { CommentId = 5, CommentName = "Saliha Çukur", CommentMail = "salihacukur@gmail.com", CommentDetails = "Harika bir çorba tarifi herkese öneririm", CommentApproved = true }
                );
            modelBuilder
                .Entity<Food>()
                .HasData(
                new Food { FoodId = 1, FoodName = "Fırında Peynirli Ekmek", FoodRecipe = "Bir kasede rendelenmiş peynirleri, yumurta, nane, pul biber, maydanoz ve zeytinyağı ile birlikte karıştırın.", FoodUrl = "firinda-peynirli-ekmek", FoodImage = "firinda-peynirli-ekmek.jpg", FoodHome = true, FoodApproved = true, FoodDeleted = false, FoodPuan = 9 },
                new Food { FoodId = 2, FoodName = "Damla Çikolatalı Kek", FoodRecipe = "Kek kalıbınızı tereyağı ile yağladıktan sonra buzdolabında 5 dakika kadar bekletirseniz pişme sonucunda kekiniz kalıptan rahatça çıkacaktır. Kakaolu keklerde kakao, sade un kullandığınız keklerde kalıba tereyağından sonra un serperseniz yine kalıptan çıkmasını kolaylaştırırsınız. Un ekledikten sonra çırpıcı ile değil spatula yada çırpma teli ile sadece karışana kadar çırpmanız kekinizin güzel kabarmasını sağlar. Unu elemeniz de daha çok kabarmasını sağlar.", FoodUrl = "damla-cikolatali-kek", FoodImage = "damla-cikolatali-kek.jpg", FoodHome = true, FoodApproved = true, FoodDeleted = false, FoodPuan = 8 },
                new Food { FoodId = 3, FoodName = "Sultan Sarması", FoodRecipe = "Bir tencerede un, toz şeker ve kakaoyu karıştırıp, üzerine yavaşça süt ilave edip sürekli karıştırarak orta ateşte pişirin.", FoodUrl = "sultan-sarmasi", FoodImage = "sultan-sarmasi.jpg", FoodHome = true, FoodApproved = true, FoodDeleted = false, FoodPuan = 9 },
                new Food { FoodId = 4, FoodName = "Avcı Böreği", FoodRecipe = "Fırında pişirme ya da kızartma esnasında dağılmaması için börekleri çok fazla iç harçla doldurmamaya ve gevşek bir şekilde sarmamaya özen gösterin.Böreklerin her tarafını çırpılmış yumurta ve galeta ununa bulayın.", FoodUrl = "avci-boregi", FoodImage = "avci-boregi.jpg", FoodHome = true, FoodApproved = true, FoodDeleted = false, FoodPuan = 9 },
                new Food { FoodId = 5, FoodName = "Mercimek Çorbası", FoodRecipe = "Zeytinyağını koyduğunuz tencereyi orta-kısık ateşe alarak ısıtın.Soğanı rendeleyin veya küp küp doğrağın, tencereye ekleyerek hafifçe kavurmaya başlayın.", FoodUrl = "mercimek-corbasi", FoodImage = "mercimek-corbasi.jpg", FoodHome = true, FoodApproved = true, FoodDeleted = false, FoodPuan = 9 }
                );
            modelBuilder
                .Entity<Material>()
                .HasData(
                new Material() { MaterialId = 1, MaterialName = "Ayçiçek Yağı" },
                new Material() { MaterialId = 2, MaterialName = "Kuru Soğan" },
                new Material() { MaterialId = 3, MaterialName = "Un" },
                new Material() { MaterialId = 4, MaterialName = "Havuç" },
                new Material() { MaterialId = 5, MaterialName = "Patates" },
                new Material() { MaterialId = 6, MaterialName = "Tuz" },
                new Material() { MaterialId = 7, MaterialName = "Karabiber" },
                new Material() { MaterialId = 8, MaterialName = "Kırmızı Mercimek" },
                new Material() { MaterialId = 9, MaterialName = "Sarı Mercimek" },
                new Material() { MaterialId = 10, MaterialName = "Su" },
                new Material() { MaterialId = 11, MaterialName = "Tereyağ" },
                new Material() { MaterialId = 12, MaterialName = "Kırmızı Toz Biber" }
                );
            modelBuilder
                .Entity<FoodMaterial>()
                .HasData(
                new FoodMaterial() { FoodId = 1, MaterialId = 1 },
                new FoodMaterial() { FoodId = 1, MaterialId = 2 },
                new FoodMaterial() { FoodId = 1, MaterialId = 3 },
                new FoodMaterial() { FoodId = 1, MaterialId = 4 },
                new FoodMaterial() { FoodId = 1, MaterialId = 5 },
                new FoodMaterial() { FoodId = 1, MaterialId = 6 },
                new FoodMaterial() { FoodId = 1, MaterialId = 7 },
                new FoodMaterial() { FoodId = 1, MaterialId = 8 },
                new FoodMaterial() { FoodId = 1, MaterialId = 9 },
                new FoodMaterial() { FoodId = 1, MaterialId = 10 },
                new FoodMaterial() { FoodId = 1, MaterialId = 11 },
                new FoodMaterial() { FoodId = 1, MaterialId = 12 }
                );
            modelBuilder
                .Entity<FoodCategory>()
                .HasData(
                new FoodCategory() { FoodId = 1, CategoryId = 1 },
                new FoodCategory() { FoodId = 2, CategoryId = 2 },
                new FoodCategory() { FoodId = 3, CategoryId = 3 },
                new FoodCategory() { FoodId = 4, CategoryId = 4 },
                new FoodCategory() { FoodId = 5, CategoryId = 5 }
                );
        }
    }
}
