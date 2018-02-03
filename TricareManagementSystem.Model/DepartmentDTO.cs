using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricareManagementSystem.Model
{
    public class DepartmentDTO
    {
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public Nullable<System.DateTime> DateOfCreation { get; set; }
    }
}
