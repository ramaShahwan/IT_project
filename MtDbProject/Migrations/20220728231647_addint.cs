using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDbProject.Migrations
{
    public partial class addint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhotoLearnTrack",
                table: "Learn_Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoLearnTrack",
                table: "Learn_Tracks");
        }
    }
}
