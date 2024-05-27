using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public class Search_By_Courses_By_CourseId_And_Level_NameDto
    {
        public string CourseName { get; set; }
        public Language Language_Name { get; set; }
        public Level Level_Name { get; set; }
        public string URLCourse { get; set; }
        public string LearnTrackName { get; set; }
        public Specialize Specialize_Name { get; set; }
    }
   
   
}

