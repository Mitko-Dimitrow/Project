using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zoro.Migrations
{
    public partial class FieldNameChangeAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "genre",
                table: "AnimeDetails",
                newName: "genres");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "genres",
                table: "AnimeDetails",
                newName: "genre");
        }
    }
}
