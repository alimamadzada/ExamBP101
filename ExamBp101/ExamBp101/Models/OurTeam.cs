using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamBp101.Models
{
    public class OurTeam : BaseEntity
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string TwitterIcon { get; set; }
        public string FacebookIcon { get; set; }
        public string LinkedInIcon { get; set; }
    }
}
