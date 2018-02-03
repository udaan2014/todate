using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricareManagementSystem.Model
{
    public class RegulationDepartment
    {
        public int RegulationId { get; set; }
        public string DepartmentId { get; set; }
        public Nullable<bool> EmployeeAccess { get; set; }
    }
}
