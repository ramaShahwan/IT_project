using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public  class Get_All_Scholarships_For_StudentDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Specialize Specialize_Name { get; set; }
        public string University_Name { get; set; }
        public Scholarshiptype type { get; set; }
        public DateTime Date_Log_Scholarship { get; set; }

        public int Count_Student_SCholarship { get; set; }

    }
}
