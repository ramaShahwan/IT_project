using ITE_Project.Dto.Scholarship;
using ITE_Project.Dto.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Std_Scholarship
{
   public class Std_ScholarshipDto
    {
        public int Std_ScholarshipId { get; set; }
        public int ScholarshipId { get; set; }
        public bool Taken { get; set; }
        public int StudentId { get; set; }
        public DateTime Date_Log_Scholarship { get; set; }
        public virtual ScholarshipDto scholarship { get; set; }
        public virtual StudentDto student { get; set; }
    }
}
