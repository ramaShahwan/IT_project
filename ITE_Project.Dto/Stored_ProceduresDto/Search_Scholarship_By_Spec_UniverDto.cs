using ITE_Project.Dto.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
    public class Search_Scholarship_By_Spec_UniverDto
    {
        //public int ScholarshipId { get; set; }
        //public Specialize Specialize_Name { get; set; }
        //public virtual UniversityDto University { get; set; }
        public int MyProperty { get; set; }
        public string Description { get; set; }
        public ScholarshipLevel Level { get; set; }
        public Scholarshiptype type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
