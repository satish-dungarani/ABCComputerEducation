using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace ABCComputerEducation.DAL
{
    public class UserMasterDAL : BaseDAL
    {
        public DataTable CheckAuthDetail(string UserName , string Password)
        {
            try
            {
                DataTable _DT = new DataTable();
                Database db = new SqlDatabase(ConnectionString);
                using(DbCommand _ObjCmd = db.GetStoredProcCommand("sp_CheckAuthentication_Get"))
                {
                    db.AddInParameter(_ObjCmd, "@UserName", DbType.String, UserName);
                    db.AddInParameter(_ObjCmd, "@Password", DbType.String, Password);

                    _DT = db.ExecuteDataSet(_ObjCmd).Tables[0];
                }
                return _DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Change Password
        public string ChangePassword(string UserName, string Password)
        {
            try
            {
                string _Result = string.Empty;
                Database db = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = db.GetStoredProcCommand("sp_UserMaster_Change"))
                {
                    db.AddInParameter(_ObjCmd, "@pUserName", DbType.String, UserName);
                    db.AddInParameter(_ObjCmd, "@pPassword", DbType.String, Password);

                    _Result = db.ExecuteScalar(_ObjCmd).ToString();
                }
                return _Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
