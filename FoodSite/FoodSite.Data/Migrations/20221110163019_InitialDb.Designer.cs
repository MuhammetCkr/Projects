﻿// <auto-generated />
using System;
using FoodSite.Data.Concrete.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FoodSite.Data.Migrations
{
    [DbContext(typeof(FoodSiteContext))]
    [Migration("20221110163019_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("FoodSite.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Atıştırmalık",
                            Name = "Atıştırmalık",
                            Url = "cigkofte"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Başlangıç Tabağı",
                            Name = "Çorba",
                            Url = "corba"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Kahvaltı Tabağı",
                            Name = "Kahvaltı",
                            Url = "kahvalti"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Tatlı Tabağı",
                            Name = "Tatlı",
                            Url = "tatli"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Hamur içi",
                            Name = "Börek",
                            Url = "borek"
                        });
                });

            modelBuilder.Entity("FoodSite.Entity.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentContent")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Point")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("FoodSite.Entity.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Point")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Ayçiçek Yağı",
                            Point = 0m
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Kuru Soğan",
                            Point = 0m
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Un",
                            Point = 0m
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Havuç",
                            Point = 0m
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Patates",
                            Point = 0m
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Tuz",
                            Point = 0m
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Karabiber",
                            Point = 0m
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Kırmızı Mercimek",
                            Point = 0m
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Sarı Mercimek",
                            Point = 0m
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Su",
                            Point = 0m
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Tereyağ",
                            Point = 0m
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsApproved = false,
                            IsDeleted = false,
                            IsHome = false,
                            Name = "Kırmızı Toz Biber",
                            Point = 0m
                        });
                });

            modelBuilder.Entity("FoodSite.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Point")
                        .HasColumnType("TEXT");

                    b.Property<string>("Properties")
                        .HasColumnType("TEXT");

                    b.Property<string>("Recipe")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "mercimek-corbasi.jpg",
                            IsApproved = true,
                            IsDeleted = false,
                            IsHome = true,
                            Name = "Mercimek Çorbası",
                            Point = 0m,
                            Properties = "Çorba",
                            Url = "mercimek-corbasi"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "ezogelin-corbasi.jpg",
                            IsApproved = true,
                            IsDeleted = false,
                            IsHome = true,
                            Name = "Egogelin Çorbası",
                            Point = 0m,
                            Properties = "Çorba",
                            Url = "ezogelin-corbasi"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "cig-kofte.jpeg",
                            IsApproved = true,
                            IsDeleted = false,
                            IsHome = true,
                            Name = "Çiğ Köfte",
                            Point = 0m,
                            Properties = "Atıştırmalık",
                            Url = "cig-kofte"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "kiymali-borek.jpg",
                            IsApproved = true,
                            IsDeleted = false,
                            IsHome = true,
                            Name = "Patatesli Sigara Böreği",
                            Point = 0m,
                            Properties = "Atıştırmalık",
                            Url = "kiymali-sigara-boregi"
                        });
                });

            modelBuilder.Entity("FoodSite.Entity.ProductCategory", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1
                        });
                });

            modelBuilder.Entity("FoodSite.Entity.ProductComment", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "CommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("ProductComments");
                });

            modelBuilder.Entity("FoodSite.Entity.ProductMaterial", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaterialId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "MaterialId");

                    b.HasIndex("MaterialId");

                    b.ToTable("ProductMaterials");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            MaterialId = 1
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 2
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 3
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 4
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 5
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 6
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 7
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 8
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 9
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 10
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 11
                        },
                        new
                        {
                            ProductId = 1,
                            MaterialId = 12
                        });
                });

            modelBuilder.Entity("FoodSite.Entity.ProductCategory", b =>
                {
                    b.HasOne("FoodSite.Entity.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodSite.Entity.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodSite.Entity.ProductComment", b =>
                {
                    b.HasOne("FoodSite.Entity.Comment", "Comment")
                        .WithMany("ProductComments")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodSite.Entity.Product", "Product")
                        .WithMany("ProductComments")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodSite.Entity.ProductMaterial", b =>
                {
                    b.HasOne("FoodSite.Entity.Material", "Material")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FoodSite.Entity.Product", "Product")
                        .WithMany("ProductMaterials")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FoodSite.Entity.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("FoodSite.Entity.Comment", b =>
                {
                    b.Navigation("ProductComments");
                });

            modelBuilder.Entity("FoodSite.Entity.Material", b =>
                {
                    b.Navigation("ProductMaterials");
                });

            modelBuilder.Entity("FoodSite.Entity.Product", b =>
                {
                    b.Navigation("ProductCategories");

                    b.Navigation("ProductComments");

                    b.Navigation("ProductMaterials");
                });
#pragma warning restore 612, 618
        }
    }
}
