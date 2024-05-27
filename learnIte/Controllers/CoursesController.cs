using ITE_Project.Dto.Course;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace learnIte.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseRepo _repo;
        private readonly IStored_ProceduresRepo _repo2;
        public CoursesController(ICourseRepo repo,  IStored_ProceduresRepo repo2)
        {
            _repo2 = repo2;
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAllCourse());
        }
        public IActionResult GetCourse(int CourseId, int Level_Name)
        {
            var c = _repo.GetCourseById(CourseId);
            // ViewData["course"]= Irep.Search_For_Courses_By_CourseName_And_Level_Name(CourseName, Level_Name);
            var res = _repo2.Search_For_Courses_By_CourseName_And_Level_Name(c.CourseName, Level_Name);

            List<CourseDto> Courses = new List<CourseDto>();
            foreach (var item in res)
            {
                CourseDto course = new CourseDto();
                course.CourseName = item.CourseName;
                course.Level_Name = (Level)item.Level_Name;
                course.Photo = item.Photo;
                course.URLCourse = item.URLCourse;
                course.Language_Name = (Language)item.Language_Name;
                Courses.Add(course);
            }
            return View("Index", Courses);
        }
        
    }
}
