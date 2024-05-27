using ITE_Project.Dto.Course_LT;
using ITE_Project.Dto.Student;
using ITE_Project.Dto.Student_LT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITE_Project.Dto.Learn_Track
{
   public class Learn_TrackDto
    {
        public int LearnTrackId { get; set; }
        public string LearnTrackName { get; set; }
        public string Description { get; set; }
        public Specialize Specialize_Name { get; set; }
        public string PhotoLearnTrack { get; set; }

        public virtual ICollection<Course_LTDto> Course_Learn_Track { get; set; }
        public virtual ICollection<Student_LTDto> Student_LT { get; set; }
    }
    public enum Specialize
    {
        Software,
        ComputerNetworks,
        ArtificialIntelligence
    }
}
