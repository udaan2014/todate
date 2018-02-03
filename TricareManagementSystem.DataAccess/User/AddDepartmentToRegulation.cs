using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricareManagementSystem.DataAccess.User
{
    public class AddDepartmentToRegulation
    {
        public bool Add(int regulationId, string departmentId)
        {

            SqlParameter[] _parameters =
                {
                new SqlParameter("@RegulationId",regulationId),
                new SqlParameter("@DepartmentId",departmentId)
            };

            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedure.ADD_REGULATION_DEPARTMENT);
            dbHelper.Parameters = _parameters;
            return dbHelper.ExcecuteNonQuery();
        }
    }
}
