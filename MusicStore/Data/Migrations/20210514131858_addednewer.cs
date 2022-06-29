using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Store.Data.Migrations
{
    public partial class addednewer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MusicianID",
                table: "Musician",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "MusicianViewModel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicianViewModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusicianViewModel");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Musician",
                newName: "MusicianID");
        }
    }
}
