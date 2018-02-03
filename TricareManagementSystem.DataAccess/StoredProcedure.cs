using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricareManagementSystem.DataAccess
{
    public class StoredProcedure
    {         
        //**********Store Procedures for inserting Data*********        
        public const string ADD_USER = "[USP_AddUser]";
        public const string ADD_DEPARTMENT = "[USP_AddDepartment]";
        public const string ADD_ROLE = "[USP_AddRole]";
        public const string ADD_COMMENT = "[USP_AddComment]";
        public const string ADD_REGULATION = "[USP_AddRegulation]";
        public const string ADD_REGULATION_DEPARTMENT = "[USP_AddRegulationDepartment]";

        //************Procedure for Updating Data************
        public const string UPDATE_USER = "[USP_UpdateUserData]";
        public const string UPDATE_DEPARTMENT = "[USP_UpdateDepartmentData]";
        public const string UPDATE_ROLE = "[USP_UpdateRoleData]";
        public const string UPDATE_COMMENT = "[USP_UpdateCommentData]";
        public const string UPDATE_REGULATION = "[USP_UpdateRegulationData]";
        public const string UPDATE_REGULATION_DEPARTMENT = "[USP_UpdateRegulationDepartmentData]";

        //************Procedure for Viewing Data************
        public const string GET_USER_DATA = "[USP_GetUserData]";
        public const string GET_DEPARTMENT_DATA = "[USP_GetDepartmentData]";
        public const string GET_ROLE_DATA = "[USP_GetRoleData]";
        public const string GET_COMMENT_DATA = "[USP_GetCommentData]";
        public const string GET_REGULATION_DATA = "[USP_GetRegulationData]";
        public const string GET_REGULATION_DEPARTMENT_DATA = "[USP_GetRegulationDepartmentData]";

        //************Procedure for Deleting Data************
        public const string DELETE_USER_DATA = "[USP_DeleteUserData]";
        public const string DELETE_DEPARTMENT_DATA = "[USP_DeleteDepartmentData]";
        public const string DELETE_ROLE_DATA = "[USP_DeleteRoleData]";
        public const string DELETE_COMMENT_DATA = "[USP_DeleteCommentData]";
        public const string DELETE_REGULATION_DATA = "[USP_DeleteRegulationData]";
        public const string DELETE_REGULATION_DEPARTMENT_DATA = "[USP_DeleteRegulationDepartmentData]";
        
        //************Procedure for Selecting Data************
        public const string AUTHENTICATE_USER_GET_ROLE = "[USP_AuthenticateUserGetRole]";
        public const string CHECK_EMPLOYEE_ACCESS_FOR_REGULATIONS = "[USP_CheckEmployeeAccessForRegulations]";
        public const string CHECK_USER_LOGIN_DETAILS = "[USP_CheckUserLoginDetails]";
        public const string CLOSE_SPECIFIC_REGULATION = "[USP_CloseSpecificRegulation]";
        public const string COUNT_REGULATION_ACCEPTANCE = "[USP_CountRegulationAcceptance]";
        public const string COUNT_REGULATION_REJECTION = "[USP_CountRegulationRejection]";
        public const string FILTER_REGULATION_BY_STATUS = "[USP_FilterRegulationByStatus]";
        public const string FORWARD_REGULATION_TO_EMPLOYEE = "[USP_ForwardRegulationToEmployee]";
        public const string GET_CLOSED_REGULATIONS = "[USP_GetClosedRegulations]";
        public const string GET_NEW_REGULATIONS_FOR_DEPARTMENTHEAD = "[USP_GetNewRegulationsForDepartmentHead]";
        public const string GET_NEW_REGULATIONS_FOR_EMPLOYEE = "[USP_GetNewRegulationsForEmployee]";
        public const string GET_OLD_REGULATIONS_FOR_DEPARTMENT_HEAD = "[USP_GetOldRegulationsForDepartmentHead]";
        public const string GETOLDREGULATIONSFOR_EMPLOYEE = "[USP_GetOldRegulationsForEmployee]";
        public const string GET_OPENED_REGULATIONS = "[USP_GetOpenedRegulations]";
        public const string GET_ROLE_AFTER_LOGIN = "[USP_GetRoleAfterLogin]";
        public const string SEARCH_DEPARTMENTDATA = "[USP_SearchDepartmentData]";
        public const string SEARCH_REGULATIONDATA = "[USP_SearchRegulationData]";
        public const string SEARCH_USERDATA = "[USP_SearchUserData]";
        public const string SELECT_SPECIFIC_COMMENT = "[USP_SelectSpecificComment]";
        public const string VERIFY_DEPARTMENTNAME = "[USP_VerifyDepartmentName]";
        public const string VERIFY_ROLE_TYPE = "[USP_VerifyRoleType]";
        public const string VERIFY_USERE_MAILID = "[USP_VerifyUserEmailId]";
        public const string VERIFY_USER_PHONENUMBER = "[USP_VerifyUserPhonenumber]";

    }
}
