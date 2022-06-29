using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Store.Data.Migrations
{
    public partial class AddedMusicianModelNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicianMusic",
                table: "MusicianMusic");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Musician");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicianMusic",
                table: "MusicianMusic",
                columns: new[] { "ID", "MusicianID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MusicianMusic",
                table: "MusicianMusic");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Musician",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MusicianMusic",
                table: "MusicianMusic",
                column: "ID");
        }
    }
}
