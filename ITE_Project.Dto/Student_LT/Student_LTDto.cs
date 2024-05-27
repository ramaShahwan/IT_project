using ITE_Project.Dto.Learn_Track;
using ITE_Project.Dto.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Student_LT
{
   public class Student_LTDto
    {
        public int Student_LTId { get; set; }
        public float Rating { get; set; }
        public int StudentId { get; set; }
        public int LearnTrackId { get; set; }
        public virtual StudentDto Student { get; set; }
        public DateTime StartlearnTime { get; set; }
        public virtual Learn_TrackDto LearnTrack { get; set; }
    }
}
