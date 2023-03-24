using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Models
{
    public class Marks
    {
        public int MarksId { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public Subject Subject { get; set; }

        public Student Student { get; set; }

        public DateTime Date { get; set; }

        public int Mark { get; set; }  
    }
}
