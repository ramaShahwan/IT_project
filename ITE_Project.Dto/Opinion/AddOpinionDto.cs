using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Opinion
{

   public class AddOpinionDto
    {
        [Required]
        public string Name { get; set; }
        //[Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(20, ErrorMessage = "Minimum length is 20"), MaxLength(100, ErrorMessage = "Maximum length is 100")]
        public string Message { get; set; }
      
    }
}
