﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PKMFisipWebsite.Migrations.UserMigration
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20250108043006_Users")]
    partial class Users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("User", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("firstName")
                        .HasColumnType("longtext");

                    b.Property<string>("lastName")
                        .HasColumnType("longtext");

                    b.Property<string>("role")
                        .HasColumnType("longtext");

                    b.Property<string>("userEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("userPhone")
                        .HasColumnType("longtext");

                    b.HasKey("userId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
