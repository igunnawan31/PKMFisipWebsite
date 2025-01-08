using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PKMFisipWebsite.Migrations
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
