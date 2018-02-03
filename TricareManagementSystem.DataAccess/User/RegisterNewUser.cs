using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.Model;

namespace TricareManagementSystem.DataAccess.User
{
    public class RegisterNewUser
    {
        public UserDTO User { get; set; }

        public bool Register()
        {

            SqlParameter[] _parameters =
                {
                new SqlParameter("@UserName",User.UserName),
                new SqlParameter("@Password",User.Password ),
                new SqlParameter("@RoleId", User.RoleId),
                new SqlParameter("@DepartmentId", User.DepartmentId),
                new SqlParameter("@DateOfJoining", User.DateOfJoining),
                new SqlParameter("@DateOfBirth",User.DateOfBirth),
                new SqlParameter("@EmailId",User.EmailId),
                new SqlParameter("@Phonenumber", User.Phonenumber),
                new SqlParameter("@Address", User.Address),
                new SqlParameter("@SecretQuestion",User.SecretQuestion)
            };

            DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedure.ADD_USER);
            dbHelper.Parameters = _parameters;
            return dbHelper.ExcecuteNonQuery();            
        }
    }
}
