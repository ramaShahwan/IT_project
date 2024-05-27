using ITE_Project.Dto.Course_LT;
using ITE_Project.Dto.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Course
{
   public class CourseDto
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public Language Language_Name { get; set; }
        public Level Level_Name { get; set; }
        public string URLCourse { get; set; }
       
        public string corse_descraption { get; set; }
        public string Photo { get; set; }
      public virtual ICollection<Course_LTDto> Course_Learn_Track { get; set; }

    }
    public enum Language
    {
        Arabic,
        English
    }
    public enum Level
    {
        beginner,
        med,
        advanced
    }

}
