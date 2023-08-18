using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zoro.Migrations
{
    public partial class TableDesignChanges1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_GogoAnimeInnfo_GogoAnimeInnfoId",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GogoAnimeInnfo",
                newName: "AnimeId");

            migrationBuilder.RenameColumn(
                name: "GogoAnimeInnfoId",
                table: "Episodes",
                newName: "GogoAnimeInnfoAnimeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Episodes",
                newName: "EpisodeId");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_GogoAnimeInnfoId",
                table: "Episodes",
                newName: "IX_Episodes_GogoAnimeInnfoAnimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_GogoAnimeInnfo_GogoAnimeInnfoAnimeId",
                table: "Episodes",
                column: "GogoAnimeInnfoAnimeId",
                principalTable: "GogoAnimeInnfo",
                principalColumn: "AnimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_GogoAnimeInnfo_GogoAnimeInnfoAnimeId",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "AnimeId",
                table: "GogoAnimeInnfo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GogoAnimeInnfoAnimeId",
                table: "Episodes",
                newName: "GogoAnimeInnfoId");

            migrationBuilder.RenameColumn(
                name: "EpisodeId",
                table: "Episodes",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_GogoAnimeInnfoAnimeId",
                table: "Episodes",
                newName: "IX_Episodes_GogoAnimeInnfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_GogoAnimeInnfo_GogoAnimeInnfoId",
                table: "Episodes",
                column: "GogoAnimeInnfoId",
                principalTable: "GogoAnimeInnfo",
                principalColumn: "Id");
        }
    }
}
