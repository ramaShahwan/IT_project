using MyTables.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Stored_ProceduresDto
{
   public class Information_Of_Student_In_LearnTrack_By_DateDto
    {

       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required, EmailAddress, MaxLength(50)]
        public string Email { get; set; }
    }
}
