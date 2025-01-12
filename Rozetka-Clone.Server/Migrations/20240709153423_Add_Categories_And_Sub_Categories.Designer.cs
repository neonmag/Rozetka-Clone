﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rozetka_Clone.Server.Data;

#nullable disable

namespace Rozetka_Clone.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240709153423_Add_Categories_And_Sub_Categories")]
    partial class Add_Categories_And_Sub_Categories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Rozetka_Clone.Server.Entity.Categories.Categories", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("dbCategories");
                });

            modelBuilder.Entity("Rozetka_Clone.Server.Entity.Categories.CategoryUnion", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("categoryId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("subCategoryId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.HasIndex("categoryId");

                    b.HasIndex("subCategoryId");

                    b.ToTable("dbCategoriesUnion");
                });

            modelBuilder.Entity("Rozetka_Clone.Server.Entity.Categories.SubCategories", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("image")
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("dbSubCategories");
                });

            modelBuilder.Entity("Rozetka_Clone.Server.Entity.Categories.CategoryUnion", b =>
                {
                    b.HasOne("Rozetka_Clone.Server.Entity.Categories.Categories", null)
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Rozetka_Clone.Server.Entity.Categories.SubCategories", null)
                        .WithMany()
                        .HasForeignKey("subCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
