using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTables.Entities
{
    public class ScholarshipEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ScholarshipId { get; set; }
        [Required]
        
        public Scholarshiptype type { get; set; }
       [Required, MaxLength(50)]
        public Specialize Specialize_Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        public ScholarshipLevel Level { get; set; }
        public string ScholarshipImage { get; set; }

        //on to many relation
        [Required,ForeignKey("Universities")]
        public int UniversityId { get; set; }
        public virtual UniversityEntity University { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        //on to many relation
        public virtual ICollection<Std_ScholarshipEntity> Std_Scholarship { get; set; }
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
