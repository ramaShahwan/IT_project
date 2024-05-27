 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTables.Entities
{
    public class UniversityEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UniversityId { get; set; }
        [Required,MaxLength(50)]
        public string University_Name { get; set; }
        [MaxLength(100)]
        public string Country { get; set; }
        [Required, MaxLength(50)]
        public string Phone { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }

        //one to one relation
        public UserEntity user { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }

        //one to many
        public virtual ICollection<ScholarshipEntity> Scholarship { get; set; }
        

        




    }
}
