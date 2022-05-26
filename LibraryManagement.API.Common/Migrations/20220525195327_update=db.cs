using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.API.Common.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseLibrary",
                table: "Books",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "RealseDate",
                table: "Books",
                newName: "Publisher");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Books",
                newName: "ReleaseLibrary");

            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "Books",
                newName: "RealseDate");
        }
    }
}
