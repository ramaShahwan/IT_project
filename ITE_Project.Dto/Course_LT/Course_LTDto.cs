using ITE_Project.Dto.Course;
using ITE_Project.Dto.Learn_Track;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Course_LT
{
   public class Course_LTDto
    {
        public int CourseLTId { get; set; }
        public int CourseId { get; set; }
        public int LearnTrackId { get; set; }
        public virtual CourseDto Course { get; set; }
        public virtual Learn_TrackDto Learn_Track { get; set; }
    }
}
