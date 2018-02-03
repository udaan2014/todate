using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.Model;

namespace TricareManagementSystem.DataAccess.User
{
    public class AddNewDepartment
    {
        public DepartmentDTO Department { get; set; }

        public bool Add()
        {

            SqlParameter[] _parameters =
                {
                new SqlParameter("@DepartmentName",Department.DepartmentName),                
                new SqlParameter("@DateOfCreation",Department.DateOfCreation)
            };
           
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedure.ADD_REGULATION);
            dbHelper.Parameters = _parameters;
            return dbHelper.ExcecuteNonQuery();
        }
    }
}
