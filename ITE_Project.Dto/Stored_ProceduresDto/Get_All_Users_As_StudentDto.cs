﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public class Get_All_Users_As_StudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Email { get; set; }
        public Type_Of Type { get; set; }

    }
}
