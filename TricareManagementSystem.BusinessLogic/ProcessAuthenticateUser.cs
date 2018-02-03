using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.DataAccess.User;

namespace TricareManagementSystem.BusinessLogic
{
    public class ProcessAuthenticateUser
    {

        public string ProcessAuthenticate(string userid, string password)
        {
            try
            {
                AuthenticateUser userObject = new AuthenticateUser();
                return userObject.Authenticate(userid, password);
            }
            catch
            {
                throw;
            }
        }

    }
}
