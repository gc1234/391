using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmpt391Project.Model
{
    class Instructor
    {
        public int instructorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int deptId { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{instructorId} {firstName} {lastName} {deptId}";
            }
        }
    }
}
