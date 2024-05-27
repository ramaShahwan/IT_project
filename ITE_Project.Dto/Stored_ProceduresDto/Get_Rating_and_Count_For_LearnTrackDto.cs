using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public class Get_Rating_and_Count_For_LearnTrackDto
    {
        public float Rating_For_LearnTrack { get; set; }
        public string LearnTrackName { get; set; }
        public string Count_Of_Courses { get; set; }
    }
}
