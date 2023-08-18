using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zoro.Migrations
{
    public partial class ChangedNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Episodes",
                table: "AnimeInfo",
                newName: "TotalEpisodes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AnimeInfo",
                newName: "MyAnimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalEpisodes",
                table: "AnimeInfo",
                newName: "Episodes");

            migrationBuilder.RenameColumn(
                name: "MyAnimeId",
                table: "AnimeInfo",
                newName: "Id");
        }
    }
}
