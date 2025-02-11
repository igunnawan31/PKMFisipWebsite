﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PKMFisipWebsite.Database;

#nullable disable

namespace PKMFisipWebsite.Migrations.AppDbContextEBookMigrations
{
    [DbContext(typeof(AppDbContextEBook))]
    [Migration("20250108022032_migration_books")]
    partial class migration_books
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EBook", b =>
                {
                    b.Property<int>("eBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("bookId")
                        .HasColumnType("int");

                    b.Property<string>("eBookDatePublished")
                        .HasColumnType("longtext");

                    b.HasKey("eBookId");

                    b.ToTable("EBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
