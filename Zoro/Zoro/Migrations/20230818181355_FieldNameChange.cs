using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zoro.Migrations
{
    public partial class FieldNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_AnimeDetails_AnimeDetailsId",
                table: "Cast");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_AnimeDetails_AnimeDetailsId",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "AnimeDetailsId",
                table: "Episodes",
                newName: "AnimeDetailsDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_AnimeDetailsId",
                table: "Episodes",
                newName: "IX_Episodes_AnimeDetailsDetailsId");

            migrationBuilder.RenameColumn(
                name: "AnimeDetailsId",
                table: "Cast",
                newName: "AnimeDetailsDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Cast_AnimeDetailsId",
                table: "Cast",
                newName: "IX_Cast_AnimeDetailsDetailsId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AnimeDetails",
                newName: "DetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_AnimeDetails_AnimeDetailsDetailsId",
                table: "Cast",
                column: "AnimeDetailsDetailsId",
                principalTable: "AnimeDetails",
                principalColumn: "DetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_AnimeDetails_AnimeDetailsDetailsId",
                table: "Episodes",
                column: "AnimeDetailsDetailsId",
                principalTable: "AnimeDetails",
                principalColumn: "DetailsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_AnimeDetails_AnimeDetailsDetailsId",
                table: "Cast");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_AnimeDetails_AnimeDetailsDetailsId",
                table: "Episodes");

            migrationBuilder.RenameColumn(
                name: "AnimeDetailsDetailsId",
                table: "Episodes",
                newName: "AnimeDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_AnimeDetailsDetailsId",
                table: "Episodes",
                newName: "IX_Episodes_AnimeDetailsId");

            migrationBuilder.RenameColumn(
                name: "AnimeDetailsDetailsId",
                table: "Cast",
                newName: "AnimeDetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_Cast_AnimeDetailsDetailsId",
                table: "Cast",
                newName: "IX_Cast_AnimeDetailsId");

            migrationBuilder.RenameColumn(
                name: "DetailsId",
                table: "AnimeDetails",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_AnimeDetails_AnimeDetailsId",
                table: "Cast",
                column: "AnimeDetailsId",
                principalTable: "AnimeDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_AnimeDetails_AnimeDetailsId",
                table: "Episodes",
                column: "AnimeDetailsId",
                principalTable: "AnimeDetails",
                principalColumn: "Id");
        }
    }
}
