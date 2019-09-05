using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework_Core_App.Migrations
{
    public partial class BookIsbnIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IsbnIndex",
                table: "Books",
                column: "Isbn",
                unique: true,
                filter: "[Isbn] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IsbnIndex",
                table: "Books");
        }
    }
}
