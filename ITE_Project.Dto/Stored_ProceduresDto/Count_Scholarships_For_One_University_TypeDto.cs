using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public class Count_Scholarships_For_One_University_TypeDto
    {
        public string University_Name { get; set; }
        public Scholarshiptype type { get; set; }
        public int Count_Scholarship { get; set; }

    }
    public enum Scholarshiptype
    {
        Inclusive,
        partial
    }


    public enum Specialize
    {
        software,
        computerNetworks,
        artificialIntelligence
    }
    public enum ScholarshipLevel
    {
        Master_Scholarship,
        University_Scholarship,


    }
}
