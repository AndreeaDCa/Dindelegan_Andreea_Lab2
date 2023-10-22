using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dindelegan_Andreea_Lab2.Migrations
{
    public partial class SchimbareCheiePrimaraAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorId",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Book",
                newName: "BookID");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Book",
                newName: "IDAuthor");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Author",
                newName: "IDAuthor");

            migrationBuilder.AddColumn<int>(
                name: "AuthorIDAuthor",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorIDAuthor",
                table: "Book",
                column: "AuthorIDAuthor");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorIDAuthor",
                table: "Book",
                column: "AuthorIDAuthor",
                principalTable: "Author",
                principalColumn: "IDAuthor",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorIDAuthor",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorIDAuthor",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorIDAuthor",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "Book",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "IDAuthor",
                table: "Book",
                newName: "AuthorId");

            migrationBuilder.RenameColumn(
                name: "IDAuthor",
                table: "Author",
                newName: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
