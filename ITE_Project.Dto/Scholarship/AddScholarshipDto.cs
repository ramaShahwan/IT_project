using MyTables.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Scholarship
{
    public class AddScholarshipDto
    {
       
        public Scholarshiptype type { get; set; }
        public Specialize Specialize_Name { get; set; }
        public string Description { get; set; }
       
        public int UniversityId { get; set; }
        public virtual UniversityEntity University { get; set; }
        public ScholarshipLevel Level { get; set; }
      
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string StatusMassge { get; set; }
      public ScholarshipEntity Scholarship { get; set; }
        public IEnumerable<UniversityEntity> UniversityList { get; set; }
        
        public List<string> ScholarshipList { get; set; }
    }
}
