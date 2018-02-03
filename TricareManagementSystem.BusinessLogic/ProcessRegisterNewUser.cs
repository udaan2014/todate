using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.DataAccess.User;
using TricareManagementSystem.Model;

namespace TricareManagementSystem.BusinessLogic
{
    public class ProcessRegisterNewUser
    {
        public bool RegisterUser(UserDTO userObject)
        {
            try
            {
                RegisterNewUser newUserObject = new RegisterNewUser();
                newUserObject.User = userObject;
                return newUserObject.Register();
            }
            catch
            {
                throw;
            }
        }
    }
}
