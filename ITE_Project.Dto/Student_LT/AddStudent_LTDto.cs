using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Student_LT
{
   public class AddStudent_LTDto
    {
        public float Rating { get; set; }
        public DateTime StartlearnTime { get; set; }
        public int StudentId { get; set; }
        public int LearnTrackId { get; set; }

    }
}
