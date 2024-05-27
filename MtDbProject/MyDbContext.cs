using Microsoft.EntityFrameworkCore;
using System;
using MyTables.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MyTables.Entities.Stored_ProceduresEntities;
using Microsoft.AspNetCore.Identity;

namespace MyDbProject
{
    public class MyDbContext: IdentityDbContext<UserEntity, IdentityRole<int>, int>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Learn_TrackEntity> Learn_Tracks { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<Course_LTEntity> Course_LT { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UniversityEntity> Universities { get; set; }
        public DbSet<StudentEntity> Students { get; set; }

        public DbSet<Student_LTEntity> Student_LTs { get; set; }
        public DbSet<Std_ScholarshipEntity> Std_Scholarships { get; set; }
        public DbSet<ScholarshipEntity> Scholarships { get; set; }
        public DbSet<OpinionEntity> opinions { get; set; }
        // public object UniversityEntity { get; set; }
        public DbSet<Get_Rating_and_Count_For_LearnTrackEntity> Get_Rating_and_Count_For_LearnTracks { get; set; }
        public DbSet<LearnTrack_For_SpecializeName_SelectedEntity> LearnTrack_For_SpecializeName_Selecteds { get; set; }
        public DbSet<Level_For_Course_SelectedEntity> Level_For_Course_Selecteds { get; set; }
        public DbSet<Count_Of_Student_In_LearnTrack_By_DateEntity> Count_Of_Student_In_LearnTrack_By_Dates { get; set; }
        public DbSet<All_Information_For_Courses_In_LearnTrackEntity> All_Information_For_Courses_In_LearnTracks { get; set; }
      
        public DbSet<Search_By_Courses_By_CourseId_And_Level_NameEntity> Search_By_Courses_By_CourseId_And_Level_Names { get; set; }
        public DbSet<Search_For_LearnTrack_By_Specialize_NameEntity> Search_For_LearnTrack_By_Specialize_Names { get; set; }
        public DbSet<Select_Details_Scholarship_By_University_Or_StudentEntity> Select_Details_Scholarship_By_University_Or_Students { get; set; }
        public DbSet<Count_Scholarships_For_One_University_TypeEntity> CountScholarshipsForOneUniversityTypes { get; set; }
        public DbSet<Get_All_Scholarships_For_StudentEntity> GetAllScholarshipsForStudents { get; set; }
       
        public DbSet<Get_All_Users_As_StudentEntity> GetAllUsersAsStudents { get; set; }
        public DbSet<Get_All_Users_As_UniversityEntity> GetAllUsersAsUniversities { get; set; }
        public DbSet<Count_Of_Student_In_Specialize_Name_Of_LearnTrackEntity> Count_Of_Student_In_Specialize_Name_Of_LearnTracks { get; set; }
        public DbSet<Information_Of_LearnTrack_For_StudentEntity> Information_Of_LearnTrack_For_Students { get; set; }
        public DbSet<UniversityNameByScholarEntity> UniversityNameByScholars { get; set; }
        public DbSet<Information_Of_Student_In_LearnTrack_By_DateEntity> Information_Of_Student_In_LearnTrack_By_Dates { get; set; }
        public DbSet<Count_Of_Student_In_Scholarship_By_DateEntity> Count_Of_Student_In_Scholarship_By_Dates { get; set; }
        public DbSet<Search_For_Course_By_CourseName_and_Level_NameEntity> Search_By_Courses_By_CourseName_And_Level_Names { get; set; }
        public DbSet<Search_Scholarship_By_Spec_UniverEntity> SearchScholarshipBySpecUnivers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<UserEntity>().HasOne(m => m.university).WithOne(m => m.user).HasForeignKey<UniversityEntity>(m => m.UserId);
            builder.Entity<UserEntity>().HasOne(m => m.student).WithOne(m => m.user).HasForeignKey<StudentEntity>(m => m.UserId);
            builder.Entity<All_Information_For_Courses_In_LearnTrackEntity>().HasNoKey();
            builder.Entity<Search_By_Courses_By_CourseId_And_Level_NameEntity>().HasNoKey();
            builder.Entity<Search_For_LearnTrack_By_Specialize_NameEntity>().HasNoKey();
            builder.Entity<Count_Scholarships_For_One_University_TypeEntity>().HasNoKey();
            builder.Entity<Get_All_Scholarships_For_StudentEntity>().HasNoKey();
            builder.Entity<Select_Details_Scholarship_By_University_Or_StudentEntity>().HasNoKey();
            builder.Entity<Get_All_Users_As_StudentEntity>().HasNoKey();
            builder.Entity<Get_All_Users_As_UniversityEntity>().HasNoKey();
            builder.Entity<Count_Of_Student_In_Specialize_Name_Of_LearnTrackEntity>().HasNoKey();
            builder.Entity<Information_Of_LearnTrack_For_StudentEntity>().HasNoKey();
            builder.Entity<Get_Rating_and_Count_For_LearnTrackEntity>().HasNoKey();
            builder.Entity<LearnTrack_For_SpecializeName_SelectedEntity>().HasNoKey();
            builder.Entity<Level_For_Course_SelectedEntity>().HasNoKey();
            builder.Entity<Count_Of_Student_In_LearnTrack_By_DateEntity>().HasNoKey();
            builder.Entity<UniversityNameByScholarEntity>().HasNoKey();
            builder.Entity<Search_Scholarship_By_Spec_UniverEntity>().HasNoKey();
            builder.Entity<Information_Of_Student_In_LearnTrack_By_DateEntity>().HasNoKey();
            builder.Entity<Search_For_Course_By_CourseName_and_Level_NameEntity>().HasNoKey();
            builder.Entity<Count_Of_Student_In_Scholarship_By_DateEntity>().HasNoKey();
        }
    }

}
