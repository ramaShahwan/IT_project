using ITE_Project.Dto.Course;
using ITE_Project.Dto.Scholarship;
using ITE_Project.Dto.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.University
{
    public class UniversityDto
    {
        public int UniversityId { get; set; }
        public string University_Name { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int UserId { get; set; }
        public UserDto user { get; set; }
        public virtual ICollection<ScholarshipDto> Scholarship { get; set; }
       
    }
}
