using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Store.Data.Migrations
{
    public partial class AddedMusicModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Music",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Musician",
                columns: table => new
                {
                    MusicianID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musician", x => x.MusicianID);
                });

            migrationBuilder.CreateTable(
                name: "MusicianMusic",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MusicID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MusicianID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianMusic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MusicianMusic_Music_MusicID",
                        column: x => x.MusicID,
                        principalTable: "Music",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MusicianMusic_Musician_MusicianID",
                        column: x => x.MusicianID,
                        principalTable: "Musician",
                        principalColumn: "MusicianID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MusicianMusic_MusicianID",
                table: "MusicianMusic",
                column: "MusicianID");

            migrationBuilder.CreateIndex(
                name: "IX_MusicianMusic_MusicID",
                table: "MusicianMusic",
                column: "MusicID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicianMusic");

            migrationBuilder.DropTable(
                name: "Music");

            migrationBuilder.DropTable(
                name: "Musician");
        }
    }
}
