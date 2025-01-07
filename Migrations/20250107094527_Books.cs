using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace PKMFisipWebsite.Migrations
{
    /// <inheritdoc />
    public partial class Books : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    authorId = table.Column<string>(type: "varchar(255)", nullable: false),
                    authorName = table.Column<string>(type: "longtext", nullable: true),
                    authorEmail = table.Column<string>(type: "longtext", nullable: true),
                    authorPhone = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.authorId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Authorships",
                columns: table => new
                {
                    authorshipId = table.Column<string>(type: "varchar(255)", nullable: false),
                    authorId = table.Column<string>(type: "longtext", nullable: true),
                    bookId = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorships", x => x.authorshipId);
                })
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

            migrationBuilder.CreateTable(
                name: "BooksPublisheds",
                columns: table => new
                {
                    booksPublishedId = table.Column<string>(type: "varchar(255)", nullable: false),
                    publisherId = table.Column<string>(type: "longtext", nullable: true),
                    bookId = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksPublisheds", x => x.booksPublishedId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "HasReads",
                columns: table => new
                {
                    hasReadId = table.Column<string>(type: "varchar(255)", nullable: false),
                    bookId = table.Column<string>(type: "longtext", nullable: true),
                    userId = table.Column<string>(type: "longtext", nullable: true),
                    lastRead = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HasReads", x => x.hasReadId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "IsReadings",
                columns: table => new
                {
                    IsReadingId = table.Column<string>(type: "varchar(255)", nullable: false),
                    userId = table.Column<string>(type: "longtext", nullable: true),
                    bookId = table.Column<string>(type: "longtext", nullable: true),
                    lastPage = table.Column<string>(type: "longtext", nullable: true),
                    lastRead = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IsReadings", x => x.IsReadingId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    publisherId = table.Column<string>(type: "varchar(255)", nullable: false),
                    publisherName = table.Column<string>(type: "longtext", nullable: true),
                    publisherEmail = table.Column<string>(type: "longtext", nullable: true),
                    publisherPhone = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.publisherId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReadLaters",
                columns: table => new
                {
                    readLaterId = table.Column<string>(type: "varchar(255)", nullable: false),
                    userId = table.Column<string>(type: "longtext", nullable: true),
                    bookId = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadLaters", x => x.readLaterId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<string>(type: "varchar(255)", nullable: false),
                    firstName = table.Column<string>(type: "longtext", nullable: true),
                    lastName = table.Column<string>(type: "longtext", nullable: true),
                    userEmail = table.Column<string>(type: "longtext", nullable: true),
                    userPhone = table.Column<string>(type: "longtext", nullable: true),
                    role = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Authorships");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BooksPublisheds");

            migrationBuilder.DropTable(
                name: "HasReads");

            migrationBuilder.DropTable(
                name: "IsReadings");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "ReadLaters");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
