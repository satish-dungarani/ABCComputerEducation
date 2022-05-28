using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace ABCComputerEducation.DAL
{
    public class MasterValuesDAL : BaseDAL
    {
        //Insert And Update Master Values Data
        public int SaveMasterValues(int pMasterValId,int pRefMasterSetup_MasterSetupId,string pMasterValue,string pShortValue,
            string pMasterDesc, string pOtherValue, int pUser, string pTerminal)
        {
            try
            {
                int MasterValId = 0;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_MasterValues_Set"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pMasterValId", DbType.Int32, pMasterValId);
                    _DB.AddInParameter(_ObjCmd, "@pRefMasterSetup_MasterSetupId", DbType.Int32, pRefMasterSetup_MasterSetupId);
                    _DB.AddInParameter(_ObjCmd, "@pMasterValue", DbType.String, pMasterValue);
                    _DB.AddInParameter(_ObjCmd, "@pShortValue", DbType.String, pShortValue);
                    _DB.AddInParameter(_ObjCmd, "@pMasterDesc", DbType.String, pMasterDesc);
                    _DB.AddInParameter(_ObjCmd, "@pOtherValue", DbType.String, pOtherValue);
                    _DB.AddInParameter(_ObjCmd, "@pUser", DbType.Int32, pUser);
                    _DB.AddInParameter(_ObjCmd, "@pTerminal", DbType.String, pTerminal);
                    MasterValId = Convert.ToInt32(_DB.ExecuteScalar(_ObjCmd));
                }

                return MasterValId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retrive Master Value Data Base on MasterValId and Master Setup Id or All
        public DataTable GetMasterValues(int? pMasterValId = null, int? pRefMasterSetup_MasterSetupId = null)
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_MasterValues_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pMasterValId", DbType.Int32, pMasterValId);
                    _DB.AddInParameter(_ObjCmd, "@pRefMasterSetup_MasterSetupId", DbType.Int32, pRefMasterSetup_MasterSetupId);
                    _DT = _DB.ExecuteDataSet(_ObjCmd).Tables[0];
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
