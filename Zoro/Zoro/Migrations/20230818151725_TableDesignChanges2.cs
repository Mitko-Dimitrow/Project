using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zoro.Migrations
{
    public partial class TableDesignChanges2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "GogoAnimeInnfo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "Episodes",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GogoAnimeInnfo",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Episodes",
                newName: "Slug");
        }
    }
}
