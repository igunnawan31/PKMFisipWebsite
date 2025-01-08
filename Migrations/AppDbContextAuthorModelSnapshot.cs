﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PKMFisipWebsite.Database;

#nullable disable

namespace PKMFisipWebsite.Migrations
{
    [DbContext(typeof(AppDbContextAuthor))]
    partial class AppDbContextAuthorModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Author", b =>
                {
                    b.Property<string>("authorId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("authorEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("authorName")
                        .HasColumnType("longtext");

                    b.Property<string>("authorPhone")
                        .HasColumnType("longtext");

                    b.HasKey("authorId");

                    b.ToTable("Authors");
                });
#pragma warning restore 612, 618
        }
    }
}
