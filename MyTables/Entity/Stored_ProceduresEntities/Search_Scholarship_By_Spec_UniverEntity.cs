using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTables.Entities.Stored_ProceduresEntities
{
    public class Search_Scholarship_By_Spec_UniverEntity
    {
        //public int ScholarshipId { get; set; }
        //public Specialize Specialize_Name { get; set; }
        //public virtual UniversityEntity University { get; set; }
        public string Description { get; set; }
        public Scholarshiptype type { get; set; }
        public ScholarshipLevel Level { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
