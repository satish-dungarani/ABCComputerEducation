using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ABCComputerEducation.DAL;

namespace ABCComputerEducation.BLL
{
    public class UserMasterBLL : BaseBLL
    {
        UserMasterDAL _ObjUserMasterDAL = new UserMasterDAL();

        #region "Properites"
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        #endregion

        #region "Action Methods"
        public DataTable CehckAuthentication(string UserName , string Password)
        {
            try
            {
                return _ObjUserMasterDAL.CheckAuthDetail(UserName, Password); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Change Password
        public string ChangePassword()
        {
            try
            {
                return _ObjUserMasterDAL.ChangePassword(UserName, Password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
