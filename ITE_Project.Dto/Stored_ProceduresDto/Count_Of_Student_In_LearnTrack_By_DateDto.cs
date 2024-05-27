using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   
    public class Count_Of_Student_In_LearnTrack_By_DateDto
    {
        public string CountOfStudent { get; set; }
        public int LearnTrackId { get; set; }
       
        public string LearnTrackName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
