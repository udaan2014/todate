using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricareManagementSystem.Model
{
    public class UserDTO
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string DepartmentId { get; set; }
        public Nullable<System.DateTime> DateOfJoining { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string EmailId { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string SecretQuestion { get; set; }
    }
}
