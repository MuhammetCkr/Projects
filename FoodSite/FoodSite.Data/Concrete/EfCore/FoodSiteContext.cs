using FoodSite.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodSite.Data.Concrete.EfCore
{
    public class FoodSiteContext : DbContext
    {
        public FoodSiteContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductMaterial> ProductMaterials { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<ProductCategory>()
                .HasKey(pc => new
                {
                    pc.ProductId,
                    pc.CategoryId
                });
            modelBuilder
                .Entity<ProductComment>()
                .HasKey(pcm => new
                {
                    pcm.ProductId,
                    pcm.CommentId
                });
            modelBuilder
                .Entity<ProductMaterial>()
                .HasKey(pm => new
                {
                    pm.ProductId,
                    pm.MaterialId
                });

            modelBuilder
                .Entity<Category>()
                .HasData(

                new Category() { Id = 1, Name = "Atıştırmalık", Description = "Atıştırmalık", Url = "atistirmalik" },
                new Category() { Id = 2, Name = "Çorba", Description = "Başlangıç Tabağı", Url = "corba" },
                new Category() { Id = 3, Name = "Kahvaltı", Description = "Kahvaltı Tabağı", Url = "kahvalti" },
                new Category() { Id = 4, Name = "Tatlı", Description = "Tatlı Tabağı", Url = "tatli" },
                new Category() { Id = 5, Name = "Börek", Description = "Hamur içi", Url = "borek" }
                );
            modelBuilder
                .Entity<Product>()
                .HasData(
                new Product() { Id = 1, Name = "Mercimek Çorbası", Properties = "Çorba", Url = "mercimek-corbasi", ImageUrl = "mercimek-corbasi.jpg", IsApproved = true, IsDeleted = false, IsHome = true },
                new Product() { Id = 2, Name = "Ezogelin Çorbası", Properties = "Çorba", Url = "ezogelin-corbasi", ImageUrl = "ezogelin-corbasi.jpg", IsApproved = true, IsDeleted = false, IsHome = true },
                new Product() { Id = 3, Name = "Çiğ Köfte", Properties = "Atıştırmalık", Url = "cig-kofte", ImageUrl = "cig-kofte.jpeg", IsApproved = true, IsDeleted = false, IsHome = true },
                new Product() { Id = 4, Name = "Kıymalı Böreği", Properties = "Börek", Url = "kiymali-sigara-boregi", ImageUrl = "kiymali-borek.jpg", IsApproved = true, IsDeleted = false, IsHome = true }
                );
            modelBuilder
                .Entity<Material>()
                .HasData(
                new Material() { Id = 1, Name = "Ayçiçek Yağı" },
                new Material() { Id = 2, Name = "Kuru Soğan" },
                new Material() { Id = 3, Name = "Un" },
                new Material() { Id = 4, Name = "Havuç" },
                new Material() { Id = 5, Name = "Patates" },
                new Material() { Id = 6, Name = "Tuz" },
                new Material() { Id = 7, Name = "Karabiber" },
                new Material() { Id = 8, Name = "Kırmızı Mercimek" },
                new Material() { Id = 9, Name = "Sarı Mercimek" },
                new Material() { Id = 10, Name = "Su" },
                new Material() { Id = 11, Name = "Tereyağ" },
                new Material() { Id = 12, Name = "Kırmızı Toz Biber" }
                );
            modelBuilder
                .Entity<ProductMaterial>()
                .HasData(
                new ProductMaterial() { ProductId = 1, MaterialId = 1 },
                new ProductMaterial() { ProductId = 1, MaterialId = 2 },
                new ProductMaterial() { ProductId = 1, MaterialId = 3 },
                new ProductMaterial() { ProductId = 1, MaterialId = 4 },
                new ProductMaterial() { ProductId = 1, MaterialId = 5 },
                new ProductMaterial() { ProductId = 1, MaterialId = 6 },
                new ProductMaterial() { ProductId = 1, MaterialId = 7 },
                new ProductMaterial() { ProductId = 1, MaterialId = 8 },
                new ProductMaterial() { ProductId = 1, MaterialId = 9 },
                new ProductMaterial() { ProductId = 1, MaterialId = 10 },
                new ProductMaterial() { ProductId = 1, MaterialId = 11 },
                new ProductMaterial() { ProductId = 1, MaterialId = 12 }
                );
            modelBuilder
                .Entity<ProductCategory>()
                .HasData(
                new ProductCategory() { ProductId = 1, CategoryId = 2 },
                new ProductCategory() { ProductId = 2, CategoryId = 2 },
                new ProductCategory() { ProductId = 3, CategoryId = 1 },
                new ProductCategory() { ProductId = 4, CategoryId = 5 }
                );
        }

    }
}
