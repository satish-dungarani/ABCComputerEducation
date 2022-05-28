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
    public class DashboardDAL : BaseDAL
    {
        public DataSet GetDashBoardData()
        {
            try
            {
                DataSet _DS = new DataSet();
                Database _ObjDB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _ObjDB.GetStoredProcCommand("sp_DashboardData_Get"))
                {
                    _DS = _ObjDB.ExecuteDataSet(_ObjCmd);
                }
                return _DS;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
