using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zoro.Migrations
{
    public partial class NewTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "genre",
                table: "AnimeInfo",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "AnimeInfo",
                newName: "Image");

            migrationBuilder.AddColumn<Guid>(
                name: "AnimeDetailsId",
                table: "AnimeInfo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AnimeInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Episodes",
                table: "AnimeInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AnimeDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GogoAnimeInnfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubOrDub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalEpisodes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GogoAnimeInnfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Character = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VActor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimeDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cast", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cast_AnimeDetails_AnimeDetailsId",
                        column: x => x.AnimeDetailsId,
                        principalTable: "AnimeDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimeDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GogoAnimeInnfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_AnimeDetails_AnimeDetailsId",
                        column: x => x.AnimeDetailsId,
                        principalTable: "AnimeDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Episodes_GogoAnimeInnfo_GogoAnimeInnfoId",
                        column: x => x.GogoAnimeInnfoId,
                        principalTable: "GogoAnimeInnfo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeInfo_AnimeDetailsId",
                table: "AnimeInfo",
                column: "AnimeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Cast_AnimeDetailsId",
                table: "Cast",
                column: "AnimeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_AnimeDetailsId",
                table: "Episodes",
                column: "AnimeDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_GogoAnimeInnfoId",
                table: "Episodes",
                column: "GogoAnimeInnfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeInfo_AnimeDetails_AnimeDetailsId",
                table: "AnimeInfo",
                column: "AnimeDetailsId",
                principalTable: "AnimeDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeInfo_AnimeDetails_AnimeDetailsId",
                table: "AnimeInfo");

            migrationBuilder.DropTable(
                name: "Cast");

            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "AnimeDetails");

            migrationBuilder.DropTable(
                name: "GogoAnimeInnfo");

            migrationBuilder.DropIndex(
                name: "IX_AnimeInfo_AnimeDetailsId",
                table: "AnimeInfo");

            migrationBuilder.DropColumn(
                name: "AnimeDetailsId",
                table: "AnimeInfo");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AnimeInfo");

            migrationBuilder.DropColumn(
                name: "Episodes",
                table: "AnimeInfo");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "AnimeInfo",
                newName: "genre");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "AnimeInfo",
                newName: "Status");
        }
    }
}
