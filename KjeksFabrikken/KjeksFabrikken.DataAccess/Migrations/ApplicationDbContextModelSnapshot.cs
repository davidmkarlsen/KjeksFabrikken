﻿// <auto-generated />
using System;
using KjeksFabrikken.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KjeksFabrikken.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KjeksFabrikken.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("KjeksFabrikken.Models.Cookie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cookies");
                });

            modelBuilder.Entity("KjeksFabrikken.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("KjeksFabrikken.ViewModels.CookieCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CookieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CookieId");

                    b.ToTable("CookieCategories");
                });

            modelBuilder.Entity("KjeksFabrikken.ViewModels.CookieIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CookieId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CookieId");

                    b.HasIndex("IngredientId");

                    b.ToTable("CookieIngredients");
                });

            modelBuilder.Entity("KjeksFabrikken.ViewModels.CookieCategory", b =>
                {
                    b.HasOne("KjeksFabrikken.Models.Category", "Category")
                        .WithMany("CookieCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KjeksFabrikken.Models.Cookie", "Cookie")
                        .WithMany("CookieCategories")
                        .HasForeignKey("CookieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Cookie");
                });

            modelBuilder.Entity("KjeksFabrikken.ViewModels.CookieIngredient", b =>
                {
                    b.HasOne("KjeksFabrikken.Models.Cookie", "Cookie")
                        .WithMany("CookieIngredients")
                        .HasForeignKey("CookieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KjeksFabrikken.Models.Ingredient", "Ingredient")
                        .WithMany("CookieIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cookie");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("KjeksFabrikken.Models.Category", b =>
                {
                    b.Navigation("CookieCategories");
                });

            modelBuilder.Entity("KjeksFabrikken.Models.Cookie", b =>
                {
                    b.Navigation("CookieCategories");

                    b.Navigation("CookieIngredients");
                });

            modelBuilder.Entity("KjeksFabrikken.Models.Ingredient", b =>
                {
                    b.Navigation("CookieIngredients");
                });
#pragma warning restore 612, 618
        }
    }
}
