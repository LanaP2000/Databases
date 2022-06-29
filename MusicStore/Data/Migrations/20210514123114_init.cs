using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Store.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicianMusic_Music_MusicID",
                table: "MusicianMusic");

            migrationBuilder.DropIndex(
                name: "IX_MusicianMusic_MusicID",
                table: "MusicianMusic");

            migrationBuilder.DropColumn(
                name: "MusicID",
                table: "MusicianMusic");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicianMusic_Music_ID",
                table: "MusicianMusic",
                column: "ID",
                principalTable: "Music",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicianMusic_Music_ID",
                table: "MusicianMusic");

            migrationBuilder.AddColumn<Guid>(
                name: "MusicID",
                table: "MusicianMusic",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MusicianMusic_MusicID",
                table: "MusicianMusic",
                column: "MusicID");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicianMusic_Music_MusicID",
                table: "MusicianMusic",
                column: "MusicID",
                principalTable: "Music",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
