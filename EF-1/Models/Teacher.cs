using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_1.Models
{
    public class Teacher
    {

        public int TeacherId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
