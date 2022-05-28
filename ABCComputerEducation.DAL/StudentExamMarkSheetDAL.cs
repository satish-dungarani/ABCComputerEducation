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
    public class StudentExamMarkSheetDAL : BaseDAL
    {
        //Insert And Update Student Fees Details Data 
        public int SaveStudentExamMarks(int pMarkSheetId,string pMarkSheetNo,int pRefAdmissionMaster_AdmissionId,
            DateTime pExamDate,string pExamResult, int pUser, string pTerminal)
        {
            try
            {
                int ReceiptId = 0;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_StudentExamMarkSheet_Set"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pMarkSheetId", DbType.Int32, pMarkSheetId);
                    _DB.AddInParameter(_ObjCmd, "@pMarkSheetNo", DbType.String, pMarkSheetNo);
                    _DB.AddInParameter(_ObjCmd, "@pRefAdmissionMaster_AdmissionId", DbType.Int32, pRefAdmissionMaster_AdmissionId);
                    _DB.AddInParameter(_ObjCmd, "@pExamDate", DbType.Date, pExamDate);
                    _DB.AddInParameter(_ObjCmd, "@pExamResult", DbType.String, pExamResult);
                    _DB.AddInParameter(_ObjCmd, "@pUser", DbType.Int32, pUser);
                    _DB.AddInParameter(_ObjCmd, "@pTerminal", DbType.String, pTerminal);
                    ReceiptId = Convert.ToInt32(_DB.ExecuteScalar(_ObjCmd));
                }

                return ReceiptId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retrive Student Master Data Base on Student ID or All
        public DataTable GeStudentExamMarks(int? pMarkSheetId = null, DateTime? pExamDate = null, string pExamResult = null)
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_StudentExamMarkSheet_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pMarkSheetId", DbType.Int32, pMarkSheetId);
                    _DB.AddInParameter(_ObjCmd, "@pExamDate", DbType.Date, pExamDate);
                    _DB.AddInParameter(_ObjCmd, "@pExamResult", DbType.String, pExamResult);
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
