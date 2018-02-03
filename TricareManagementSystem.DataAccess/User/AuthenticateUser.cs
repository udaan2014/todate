using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricareManagementSystem.DataAccess.User
{
    public class AuthenticateUser
    {
        /// <summary>
        /// Used to Authenticate a particular User using his UserId and Password 
        /// and find its Role in the Organization
        /// </summary>
        /// <param name="id">UserId</param>
        /// <param name="password">Password</param>
        /// <returns>It returns a Valid RoleType if Authentication is Successful, else Empty STring</returns>
        public string Authenticate(string id, string password)
        {
            SqlParameter[] parameters =
               {
                new SqlParameter("@UserId",id),
                new SqlParameter("@Password",password),
                };
            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedure.AUTHENTICATE_USER_GET_ROLE);
            dbHelper.Parameters = parameters;
            SqlDataReader sqlDataReaderObject = dbHelper.ExcecuteReaderQuery();
            String roleType = string.Empty;
            if (sqlDataReaderObject.HasRows)
            {
                while (sqlDataReaderObject.Read())
                {
                    roleType= sqlDataReaderObject[0].ToString();
                }
            }
            return roleType;

        }
    }
}
