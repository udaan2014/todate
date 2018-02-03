using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.DataAccess.User;
using TricareManagementSystem.Model;

namespace TricareManagementSystem.BusinessLogic
{
    public class ProcessAddNewDepartment
    {
        public bool AddDepartment(DepartmentDTO departmentObject)
        {
            try
            {
                AddNewDepartment newDepartmentObject = new AddNewDepartment();
                newDepartmentObject.Department = departmentObject;
                return newDepartmentObject.Add();
            }
            catch
            {
                throw;
            }
        }
    }
}
