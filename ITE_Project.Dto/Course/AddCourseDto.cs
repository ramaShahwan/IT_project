using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Course
{
   public class AddCourseDto
    {
        
        public string CourseName { get; set; }
        public Language Language_Name { get; set; }
        public Level Level_Name { get; set; }
        public string URLCourse { get; set; }
       
        public string corse_descraption { get; set; }
        //public byte[] Photo { get; set; }
    }
   
}
