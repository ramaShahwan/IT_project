using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDbProject.Migrations
{
    public partial class dell : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoLearnTrack",
                table: "Learn_Tracks");

            migrationBuilder.RenameColumn(
                name: "Start_Loging",
                table: "SearchScholarshipBySpecUnivers",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "End_Loging",
                table: "SearchScholarshipBySpecUnivers",
                newName: "EndDate");

            migrationBuilder.CreateTable(
                name: "Count_Of_Student_In_Scholarship_By_Dates",
                columns: table => new
                {
                    CountOfStudent = table.Column<int>(type: "int", nullable: false),
                    Specialize_Name = table.Column<int>(type: "int", nullable: false),
                    Date_Log_Scholarship = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Information_Of_Student_In_LearnTrack_By_Dates",
                columns: table => new
                {
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Search_By_Courses_By_CourseName_And_Level_Names",
                columns: table => new
                {
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language_Name = table.Column<int>(type: "int", nullable: false),
                    Level_Name = table.Column<int>(type: "int", nullable: false),
                    URLCourse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Count_Of_Student_In_Scholarship_By_Dates");

            migrationBuilder.DropTable(
                name: "Information_Of_Student_In_LearnTrack_By_Dates");

            migrationBuilder.DropTable(
                name: "Search_By_Courses_By_CourseName_And_Level_Names");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "SearchScholarshipBySpecUnivers",
                newName: "Start_Loging");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "SearchScholarshipBySpecUnivers",
                newName: "End_Loging");

            migrationBuilder.AddColumn<byte[]>(
                name: "PhotoLearnTrack",
                table: "Learn_Tracks",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
