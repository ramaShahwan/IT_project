using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyDbProject.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_std_Scholarships_Scholarships_ScholarshipId",
                table: "std_Scholarships");

            migrationBuilder.DropForeignKey(
                name: "FK_std_Scholarships_Students_StudentId",
                table: "std_Scholarships");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_LTs_Learn_Tracks_LearnTrackId",
                table: "Student_LTs");

            migrationBuilder.DropTable(
                name: "SearchScholarshipByTypeUnivers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_std_Scholarships",
                table: "std_Scholarships");

           

           
            migrationBuilder.DropColumn(
                name: "LearnTrackName",
                table: "Count_Of_Student_In_LearnTrack_By_Dates");

            migrationBuilder.RenameTable(
                name: "std_Scholarships",
                newName: "Std_Scholarships");

            migrationBuilder.RenameIndex(
                name: "IX_std_Scholarships_StudentId",
                table: "Std_Scholarships",
                newName: "IX_Std_Scholarships_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_std_Scholarships_ScholarshipId",
                table: "Std_Scholarships",
                newName: "IX_Std_Scholarships_ScholarshipId");

          

            migrationBuilder.AddColumn<bool>(
                name: "Taken",
                table: "Std_Scholarships",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "CountOfStudent",
                table: "Count_Of_Student_In_LearnTrack_By_Dates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Std_Scholarships",
                table: "Std_Scholarships",
                column: "Std_ScholarshipId");

            migrationBuilder.CreateTable(
                name: "SearchScholarshipBySpecUnivers",
                columns: table => new
                {
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<int>(type: "int", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Start_Loging = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_Loging = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Std_Scholarships_Scholarships_ScholarshipId",
                table: "Std_Scholarships",
                column: "ScholarshipId",
                principalTable: "Scholarships",
                principalColumn: "ScholarshipId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Std_Scholarships_Students_StudentId",
                table: "Std_Scholarships",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_LTs_Learn_Tracks_LearnTrackId",
                table: "Student_LTs",
                column: "LearnTrackId",
                principalTable: "Learn_Tracks",
                principalColumn: "LearnTrackId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Std_Scholarships_Scholarships_ScholarshipId",
                table: "Std_Scholarships");

            migrationBuilder.DropForeignKey(
                name: "FK_Std_Scholarships_Students_StudentId",
                table: "Std_Scholarships");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_LTs_Learn_Tracks_LearnTrackId",
                table: "Student_LTs");

            migrationBuilder.DropTable(
                name: "SearchScholarshipBySpecUnivers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Std_Scholarships",
                table: "Std_Scholarships");

            migrationBuilder.DropColumn(
                name: "Taken",
                table: "Std_Scholarships");

            migrationBuilder.RenameTable(
                name: "Std_Scholarships",
                newName: "std_Scholarships");

            migrationBuilder.RenameIndex(
                name: "IX_Std_Scholarships_StudentId",
                table: "std_Scholarships",
                newName: "IX_std_Scholarships_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Std_Scholarships_ScholarshipId",
                table: "std_Scholarships",
                newName: "IX_std_Scholarships_ScholarshipId");

           

           

           
            migrationBuilder.AlterColumn<string>(
                name: "CountOfStudent",
                table: "Count_Of_Student_In_LearnTrack_By_Dates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LearnTrackName",
                table: "Count_Of_Student_In_LearnTrack_By_Dates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_std_Scholarships",
                table: "std_Scholarships",
                column: "Std_ScholarshipId");

            migrationBuilder.CreateTable(
                name: "SearchScholarshipByTypeUnivers",
                columns: table => new
                {
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    End_Loging = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Specialize_Name = table.Column<int>(type: "int", nullable: false),
                    Start_Loging = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tybe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.AddForeignKey(
                name: "FK_std_Scholarships_Scholarships_ScholarshipId",
                table: "std_Scholarships",
                column: "ScholarshipId",
                principalTable: "Scholarships",
                principalColumn: "ScholarshipId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_std_Scholarships_Students_StudentId",
                table: "std_Scholarships",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_LTs_Learn_Tracks_LearnTrackId",
                table: "Student_LTs",
                column: "LearnTrackId",
                principalTable: "Learn_Tracks",
                principalColumn: "LearnTrackId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
