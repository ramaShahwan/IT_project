using MyTables.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Student
{
   public class StudentDto
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        [Required, MinLength(3), MaxLength(20)]
        public string FirstName { get; set; }
        [MinLength(3), MaxLength(20)]
        public string LastName { get; set; }
        [MinLength(2), MaxLength(20)]
        public string Country { get; set; }

        [MaxLength(10), MinLength(10)]
        public string Phone { get; set; }

        [MinLength(5), MaxLength(100)]
        public string Address { get; set; }

        public DateTime Birthday { get; set; }
        [Range(60.0, 100.0)]
        public float? Average { get; set; }
        public int UserId { get; set; }
      
        public float National_examination_mark { get; set; }
        public float Master_mark { get; set; }
        public float Baccalaureate_mark { get; set; }
        public UserEntity user { get; set; }
        public virtual ICollection<Std_ScholarshipEntity> Std_Scholarship { get; set; }
        
      
    }
}
