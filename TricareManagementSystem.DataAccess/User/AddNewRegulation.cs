using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.Model;

namespace TricareManagementSystem.DataAccess.User
{
    public class AddNewRegulation
    {
        public RegulationDTO Regulation { get; set; }

        public bool Add()
        {

            SqlParameter[] _parameters =
                {
                new SqlParameter("@RegulationName",Regulation.RegulationName),
                new SqlParameter("@Description",Regulation.Description),
                new SqlParameter("@DateOfCreation",Regulation.DateOfCreation),
                new SqlParameter(" @DateOfModification",Regulation.DateOfModification)
            };                       
             
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedure.ADD_REGULATION);
            dbHelper.Parameters = _parameters;
            return dbHelper.ExcecuteNonQuery();
        }
    }
}
