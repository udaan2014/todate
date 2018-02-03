using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.DataAccess.User;

namespace TricareManagementSystem.BusinessLogic
{
    public class ProcessAddDepartmentToRegulation
    {
        public bool AddDepartment(int regulationId, string departmentId)
        {
            try
            {
                AddDepartmentToRegulation departmentToRegulationObject = new AddDepartmentToRegulation();
                return departmentToRegulationObject.Add(regulationId, departmentId);                
            }
            catch
            {
                throw;
            }
        }
    }
}
