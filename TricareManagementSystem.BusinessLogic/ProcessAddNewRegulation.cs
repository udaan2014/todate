using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.DataAccess.User;
using TricareManagementSystem.Model;

namespace TricareManagementSystem.BusinessLogic
{
    public class ProcessAddNewRegulation
    {
        public bool AddRegulation(RegulationDTO regulationObject)
        {
            try
            {
                AddNewRegulation newRegulationObject = new AddNewRegulation();
                newRegulationObject.Regulation = regulationObject;
                return newRegulationObject.Add();                
            }
            catch
            {
                throw;
            }
        }
    }
}
