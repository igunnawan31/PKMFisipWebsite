using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PKMFisipWebsite.Migrations.UserMigration
{
    /// <inheritdoc />
    public partial class Users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
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
                name: "Users");
        }
    }
}
