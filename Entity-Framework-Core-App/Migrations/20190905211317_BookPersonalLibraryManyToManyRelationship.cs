using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework_Core_App.Migrations
{
    public partial class BookPersonalLibraryManyToManyRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalLibraries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalLibraries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalLibraryBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    PersonalLibraryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalLibraryBooks", x => new { x.BookId, x.PersonalLibraryId });
                    table.ForeignKey(
                        name: "FK_PersonalLibraryBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalLibraryBooks_PersonalLibraries_PersonalLibraryId",
                        column: x => x.PersonalLibraryId,
                        principalTable: "PersonalLibraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalLibraryBooks_PersonalLibraryId",
                table: "PersonalLibraryBooks",
                column: "PersonalLibraryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalLibraryBooks");

            migrationBuilder.DropTable(
                name: "PersonalLibraries");
        }
    }
}
