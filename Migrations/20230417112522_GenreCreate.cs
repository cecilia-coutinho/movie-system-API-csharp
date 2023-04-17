﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieSystemAPI.Migrations
{
    public partial class GenreCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GenreDescription = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genres_GenreTitle",
                table: "Genres",
                column: "GenreTitle",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}