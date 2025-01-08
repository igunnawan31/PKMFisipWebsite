using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PKMFisipWebsite.Migrations.ReadingActivityMigration
{
    /// <inheritdoc />
    public partial class ReadingActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HasReads");

            migrationBuilder.DropTable(
                name: "IsReadings");

            migrationBuilder.DropTable(
                name: "ReadLaters");
        }
    }
}
