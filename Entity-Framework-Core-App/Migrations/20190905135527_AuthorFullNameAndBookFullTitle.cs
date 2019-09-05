using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework_Core_App.Migrations
{
    public partial class AuthorFullNameAndBookFullTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Authors",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Authors");
        }
    }
}
