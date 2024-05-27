using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
  public class Information_Of_LearnTrack_For_StudentDto
    {
        public string LearnTrackName { get; set; }
        public string Description { get; set; }
        public Specialize Specialize_Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
