using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace PKMFisipWebsite.Migrations.AppDbContextBookMigrations
{
    /// <inheritdoc />
    public partial class migration_books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "longtext", nullable: true),
                    datePublished = table.Column<string>(type: "longtext", nullable: true),
                    totalPage = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "longtext", nullable: true),
                    language = table.Column<string>(type: "longtext", nullable: true),
                    genre = table.Column<string>(type: "longtext", nullable: true),
                    desc = table.Column<string>(type: "longtext", nullable: true),
                    image = table.Column<byte[]>(type: "longblob", nullable: true),
                    mediaType = table.Column<int>(type: "int", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.bookId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
