using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public class Get_All_Users_As_UniversityDto
    {
        public string University_Name { get; set; }
        public String Email { get; set; }
        public Type_Of Type { get; set; }

    }
    public enum Type_Of
    {
        University,
        Student
    }
}
