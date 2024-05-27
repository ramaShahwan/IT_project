using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Scholarship
{
   public class UpdateScholarshipDto
    {
        public String Scholarship_Name { get; set; }
        public string type { get; set; }
        public string Specialize_Name { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public int UniversityId { get; set; }
    }
}
