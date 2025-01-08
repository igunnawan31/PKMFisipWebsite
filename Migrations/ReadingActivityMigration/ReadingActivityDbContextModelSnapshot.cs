﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PKMFisipWebsite.Migrations.ReadingActivityMigration
{
    [DbContext(typeof(ReadingActivityDbContext))]
    partial class ReadingActivityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("HasRead", b =>
                {
                    b.Property<string>("hasReadId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("bookId")
                        .HasColumnType("longtext");

                    b.Property<string>("lastRead")
                        .HasColumnType("longtext");

                    b.Property<string>("userId")
                        .HasColumnType("longtext");

                    b.HasKey("hasReadId");

                    b.ToTable("HasReads");
                });

            modelBuilder.Entity("IsReading", b =>
                {
                    b.Property<string>("IsReadingId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("bookId")
                        .HasColumnType("longtext");

                    b.Property<string>("lastPage")
                        .HasColumnType("longtext");

                    b.Property<string>("lastRead")
                        .HasColumnType("longtext");

                    b.Property<string>("userId")
                        .HasColumnType("longtext");

                    b.HasKey("IsReadingId");

                    b.ToTable("IsReadings");
                });

            modelBuilder.Entity("ReadLater", b =>
                {
                    b.Property<string>("readLaterId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("bookId")
                        .HasColumnType("longtext");

                    b.Property<string>("userId")
                        .HasColumnType("longtext");

                    b.HasKey("readLaterId");

                    b.ToTable("ReadLaters");
                });
#pragma warning restore 612, 618
        }
    }
}
