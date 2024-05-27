using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public class Search_For_LearnTrack_By_Specialize_NameDto
    {
        public int LearnTrackId { get; set; }
        public string PhotoLearnTrack { get; set; }
        public string LearnTrackName { get; set; }
        public string Description { get; set; }
        public Specialize Specialize_Name { get; set; }
    }
}
