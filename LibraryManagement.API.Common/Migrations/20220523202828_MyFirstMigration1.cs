using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.API.Common.Migrations
{
    public partial class MyFirstMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Ogrenci",
                table: "Ogrenci");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Oduns",
                table: "Oduns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kitap",
                table: "Kitap");

            migrationBuilder.RenameTable(
                name: "Ogrenci",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Oduns",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Kitap",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Ogrenci");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Oduns");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Kitap");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ogrenci",
                table: "Ogrenci",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Oduns",
                table: "Oduns",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kitap",
                table: "Kitap",
                column: "Id");
        }
    }
}
