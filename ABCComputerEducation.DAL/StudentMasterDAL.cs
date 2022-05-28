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
    public class StudentMastersDAL : BaseDAL
    {
        //Insert And Update Student Master Data 
        public int SaveStudentMaster(int pStudentId, string pStudentName, string pGender, string pAddress, string pCity, string pState, decimal pPincode,
            string pContactNo, decimal pPersonalNo, decimal pFatherContactNo, string pRecidentialNo, string pEmailId, string pLastEducation, 
            int pUser, string pTerminal)
        {
            try
            {
                int StudentId = 0;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_StudentMaster_Set"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pStudentId", DbType.Int32, pStudentId);
                    _DB.AddInParameter(_ObjCmd, "@pStudentName", DbType.String, pStudentName);
                    _DB.AddInParameter(_ObjCmd, "@pGender", DbType.String, pGender);
                    _DB.AddInParameter(_ObjCmd, "@pAddress", DbType.String, pAddress);
                    _DB.AddInParameter(_ObjCmd, "@pCity", DbType.String, pCity);
                    _DB.AddInParameter(_ObjCmd, "@pState", DbType.String, pState);
                    _DB.AddInParameter(_ObjCmd, "@pPincode", DbType.Decimal, pPincode);
                    _DB.AddInParameter(_ObjCmd, "@pContactNo", DbType.String, pContactNo);
                    _DB.AddInParameter(_ObjCmd, "@pPersonalNo", DbType.Decimal, pPersonalNo);
                    _DB.AddInParameter(_ObjCmd, "@pFatherContactNo", DbType.Decimal, pFatherContactNo);
                    _DB.AddInParameter(_ObjCmd, "@pRecidentialNo", DbType.String, pRecidentialNo);
                    _DB.AddInParameter(_ObjCmd, "@pEmailId", DbType.String, pEmailId);
                    _DB.AddInParameter(_ObjCmd, "@pLastEducation", DbType.String, pLastEducation);
                    _DB.AddInParameter(_ObjCmd, "@pUser", DbType.Int32, pUser);
                    _DB.AddInParameter(_ObjCmd, "@pTerminal", DbType.String, pTerminal);
                    StudentId = Convert.ToInt32(_DB.ExecuteScalar(_ObjCmd));
                }

                return StudentId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retrive Student Master Data Base on Student ID or All
        public DataTable GeStudenttMaster(int? pStudentId = null)
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_StudentMaster_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pStudentId", DbType.Int32, pStudentId);
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
