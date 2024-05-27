using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.University
{
   public class AddUniversityDto
    {
        public string University_Name { get; set; }
        public string University_Country { get; set; }
        public string University_Phone { get; set; }
        public string University_Address { get; set; }
        public int UserId { get; set; }


    }
}
