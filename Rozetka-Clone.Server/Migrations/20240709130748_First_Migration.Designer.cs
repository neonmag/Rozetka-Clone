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
    [Migration("20240709130748_First_Migration")]
    partial class First_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Rozetka_Clone.Server.Entity.Categories", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("deletedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<String>("image")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<String>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("dbCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
