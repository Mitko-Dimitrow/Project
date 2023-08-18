using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zoro.Migrations
{
    public partial class TableFieldNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnimeName",
                table: "AnimeInfo",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "AnimeInfo",
                newName: "AnimeName");
        }
    }
}
