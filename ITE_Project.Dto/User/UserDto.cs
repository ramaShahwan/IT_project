using ITE_Project.Dto.Student;
using ITE_Project.Dto.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.User
{
   public class UserDto
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public DateTimeOffset LockoutEnd { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Type_Of Type { get; set; }
        public UniversityDto university { get; set; }
        public StudentDto student { get; set; }
    }
    public enum Type_Of
    {
        University,
        Student
    }
}
