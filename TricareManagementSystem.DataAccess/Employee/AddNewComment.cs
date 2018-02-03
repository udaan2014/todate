using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.Model;

namespace TricareManagementSystem.DataAccess.Employee
{
    public class AddNewComment
    {
        public CommentDTO Comment { get; set; }

        public bool Add()
        {

            SqlParameter[] _parameters =
                {
                new SqlParameter("@UserId",Department.UserId),
                new SqlParameter("@RegulationId",Department.RegulationId),
                new SqlParameter(" @Acceptance",Department.Acceptance),
                new SqlParameter("@Description ",Department.Description),
                new SqlParameter("@DateOfCreation",Department.DateOfCreation),
                new SqlParameter("@DateOfModification",Department.DateOfModification)
            };       
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedure.ADD_COMMENT);
            dbHelper.Parameters = _parameters;
            return dbHelper.ExcecuteNonQuery();
        }
    }
}
