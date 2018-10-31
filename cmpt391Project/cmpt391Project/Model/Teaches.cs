using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmpt391Project.Model
{
    class Teaches
    {
        public int instructorId { get; set; }
        public int courseId { get; set; }
        public int sectionId { get; set; }
        public int year { get; set; }
        public string semester { get; set; }
    }
}
