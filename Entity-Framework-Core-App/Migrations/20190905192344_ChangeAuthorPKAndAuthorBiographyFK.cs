using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework_Core_App.Migrations
{
    public partial class ChangeAuthorPKAndAuthorBiographyFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBiographies_Authors_AuthorFirstName_AuthorLastName",
                table: "AuthorBiographies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_AuthorBiographies_AuthorFirstName_AuthorLastName",
                table: "AuthorBiographies");

            migrationBuilder.DropColumn(
                name: "AuthorFirstName",
                table: "AuthorBiographies");

            migrationBuilder.DropColumn(
                name: "AuthorLastName",
                table: "AuthorBiographies");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Authors",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "AuthorBiographies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBiographies_AuthorId",
                table: "AuthorBiographies",
                column: "AuthorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBiographies_Authors_AuthorId",
                table: "AuthorBiographies",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBiographies_Authors_AuthorId",
                table: "AuthorBiographies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_AuthorBiographies_AuthorId",
                table: "AuthorBiographies");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "AuthorBiographies");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Authors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Authors",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorFirstName",
                table: "AuthorBiographies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorLastName",
                table: "AuthorBiographies",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                table: "Authors",
                columns: new[] { "FirstName", "LastName" });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBiographies_AuthorFirstName_AuthorLastName",
                table: "AuthorBiographies",
                columns: new[] { "AuthorFirstName", "AuthorLastName" },
                unique: true,
                filter: "[AuthorFirstName] IS NOT NULL AND [AuthorLastName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBiographies_Authors_AuthorFirstName_AuthorLastName",
                table: "AuthorBiographies",
                columns: new[] { "AuthorFirstName", "AuthorLastName" },
                principalTable: "Authors",
                principalColumns: new[] { "FirstName", "LastName" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
