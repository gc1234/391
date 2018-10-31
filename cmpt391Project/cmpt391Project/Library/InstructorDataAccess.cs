using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using cmpt391Project.Model;

namespace cmpt391Project.Library
{
    public class InstructorDataAccess
    {
        public List<InstructorScreen> GetInstructor(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("cmpt391DB")))
            {
                //return connection.Query<Instructor>($"select * from instructor where iid = '{ id }'").ToList();
                return connection.Query<InstructorScreen>("dbo.spGetInstructorById @target_id", new { target_id = id }).ToList();
            }
        }

        public void InsertInstructor(int instId, string fName, string lName, int deptId)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("cmpt391DB")))
            {
                Instructor newInstructor = new Instructor { instructorId = instId, firstName = fName, lastName = lName, deptId = deptId };
                List<Instructor> instructors = new List<Instructor>();
                instructors.Add(newInstructor);
                connection.Execute("dbo.spInsertInsructor @instID, @fName, @lName, @deptId", instructors);
            }
        }
    }
}
