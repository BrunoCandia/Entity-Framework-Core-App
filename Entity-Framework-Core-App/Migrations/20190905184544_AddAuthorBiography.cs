using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework_Core_App.Migrations
{
    public partial class AddAuthorBiography : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthorBiographies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Biography = table.Column<string>(nullable: true),
                    AuthorFirstName = table.Column<string>(nullable: true),
                    AuthorLastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBiographies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorBiographies_Authors_AuthorFirstName_AuthorLastName",
                        columns: x => new { x.AuthorFirstName, x.AuthorLastName },
                        principalTable: "Authors",
                        principalColumns: new[] { "FirstName", "LastName" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBiographies_AuthorFirstName_AuthorLastName",
                table: "AuthorBiographies",
                columns: new[] { "AuthorFirstName", "AuthorLastName" },
                unique: true,
                filter: "[AuthorFirstName] IS NOT NULL AND [AuthorLastName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBiographies");
        }
    }
}
