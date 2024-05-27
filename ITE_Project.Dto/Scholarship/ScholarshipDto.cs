using ITE_Project.Dto.Std_Scholarship;
using ITE_Project.Dto.University;
using MyTables.Entities;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Scholarship
{
   public class ScholarshipDto
    {
        public int ScholarshipId { get; set; }
        public Scholarshiptype type { get; set; }
        public Specialize Specialize_Name { get; set; }
        public string Description { get; set; }
        public ScholarshipLevel Level { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UniversityId { get; set; }
        public ScholarshipEntity Scholarship { get; set; }
        public IEnumerable<UniversityEntity> UniversityList { get; set; }

        public List<string> ScholarshipList { get; set; }
        public virtual UniversityDto University { get; set; }
        public virtual ICollection<Std_ScholarshipDto> std_Scholarship { get; set; }
    }
    public enum Scholarshiptype
    {
        Inclusive,
        partial
    }


    public enum Specialize
    {
        Software,
        ComputerNetworks,
        ArtificialIntelligence
    }
    public enum ScholarshipLevel
    {
        Master_Scholarship,
        University_Scholarship,

    }
}
