using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricareManagementSystem.Model
{
    public class RegulationDTO
    {
        public int RegulationId { get; set; }
        public string RegulationName { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> DateOfCreation { get; set; }
        public Nullable<System.DateTime> DateOfModification { get; set; }
        
    }
}
