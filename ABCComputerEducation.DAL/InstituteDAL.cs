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
    public class InstituteDAL : BaseDAL
    {
        public DataTable GetInstituteInfo()
        {
            try
            {
                DataTable _DT = new DataTable();
                Database _ObjDb  = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _ObjDb.GetStoredProcCommand("sp_InstituteMaster_Get"))
                {
                    _DT = _ObjDb.ExecuteDataSet(_ObjCmd).Tables[0];
                }
                return _DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
