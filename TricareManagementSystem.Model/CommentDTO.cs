using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricareManagementSystem.Model
{
    public class CommentDTO
    {
        public string UserId { get; set; }
        public int RegulationId { get; set; }
        public Nullable<bool> Acceptance { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> DateOfCreation { get; set; }
        public Nullable<System.DateTime> DateOfModification { get; set; }
        
    }
}
