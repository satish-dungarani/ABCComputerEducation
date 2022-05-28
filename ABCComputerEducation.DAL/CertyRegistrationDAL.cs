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
    public class CertyRegistrationDAL : BaseDAL
    {
        //Insert And Update Certy Registration Data 
        public int SaveCertyRegistration(int pCertyId, string pRegNo, int pRefStudentExamMarkSheet_MarksheetId, DateTime pRegDate,
                string pCertyType, DateTime? pCertyRequestDate, DateTime? pCertyReceiveDate, DateTime? pCertyIssueDate, int pUser, string pTerminal)
        {
            try
            {
                int StudentId = 0;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_CertyRegistration_Set"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pCertyId", DbType.Int32, pCertyId);
                    _DB.AddInParameter(_ObjCmd, "@pRegNo", DbType.String, pRegNo);
                    _DB.AddInParameter(_ObjCmd, "@pRefStudentExamMarkSheet_MarksheetId", DbType.Int32, pRefStudentExamMarkSheet_MarksheetId);
                    _DB.AddInParameter(_ObjCmd, "@pRegDate", DbType.Date, pRegDate);
                    _DB.AddInParameter(_ObjCmd, "@pCertyType", DbType.String, pCertyType);
                    _DB.AddInParameter(_ObjCmd, "@pCertyRequestDate", DbType.Date, pCertyRequestDate);
                    _DB.AddInParameter(_ObjCmd, "@pCertyReceiveDate", DbType.Date, pCertyReceiveDate);
                    _DB.AddInParameter(_ObjCmd, "@pCertyIssueDate", DbType.Date, pCertyIssueDate);
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

        //Retrive Certy Registration Data Base on Student ID and Certy Id
        public DataTable GeCertyRegistration(int? pCertyId = null)
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_CertyRegistration_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pCertyId", DbType.Int32, @pCertyId);
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
