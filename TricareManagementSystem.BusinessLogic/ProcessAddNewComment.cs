using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TricareManagementSystem.DataAccess.Employee;
using TricareManagementSystem.Model;

namespace TricareManagementSystem.BusinessLogic
{
    public class ProcessAddNewComment
    {
        public bool AddComment(CommentDTO commentObject)
        {
            try
            {
                AddNewComment newCommentObject = new AddNewComment();
                newCommentObject.Comment = commentObject;
                return newCommentObject.Add();
            }
            catch
            {
                throw;
            }
        }
    }
}
