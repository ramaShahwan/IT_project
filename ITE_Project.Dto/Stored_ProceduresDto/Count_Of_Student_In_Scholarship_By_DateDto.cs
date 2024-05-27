using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public class Count_Of_Student_In_Scholarship_By_DateDto
    {
        public int CountOfStudent { get; set; }
        public Specialize Specialize_Name { get; set; }
        public DateTime Date_Log_Scholarship { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
