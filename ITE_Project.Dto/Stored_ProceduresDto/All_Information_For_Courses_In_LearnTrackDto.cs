using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
  public  class All_Information_For_Courses_In_LearnTrackDto
    {
        public string CourseName { get; set; }
        public Language Language_Name { get; set; }
        public Level Level_Name { get; set; }
        public string URLCourse { get; set; }
        public string LearnTrackName { get; set; }
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

