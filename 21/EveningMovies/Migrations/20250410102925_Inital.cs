using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EveningMovies.Migrations
{
    /// <inheritdoc />
    public partial class Inital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EveningMovies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Genre = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    MoodTag = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EveningMovies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EveningMovies_MoodTag",
                table: "EveningMovies",
                column: "MoodTag");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EveningMovies");
        }
    }
}
