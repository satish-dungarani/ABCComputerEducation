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
    public class StudentFeesDetailsDAL : BaseDAL
    {
        //Insert And Update Student Fees Details Data 
        public int SaveStudentFeesDetails(int pReceiptId, string pReceiptNo, int pRefAdmirssionDetail_AdmissionId, 
            int pInstallmanrNo, decimal pPaidAmount, decimal pTotalFees, decimal pPendingFees, DateTime pPaidDate,
            string pPaidBy,string pChequeNo, string pBankOfCheque,string pDepositedAccountName,DateTime? pChequeReceiveDate,
            DateTime? pChequeRequestDate, DateTime? pChequeAcceptDate, DateTime?  pChequeBounsDate,
            int pUser, string pTerminal)
        {
            try
            {
                int ReceiptId = 0;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_StudentFeesDetails_Set"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pReceiptId", DbType.Int32, pReceiptId);
                    _DB.AddInParameter(_ObjCmd, "@pReceiptNo", DbType.String, pReceiptNo);
                    _DB.AddInParameter(_ObjCmd, "@pRefAdmirssionDetail_AdmissionId", DbType.Int32, pRefAdmirssionDetail_AdmissionId);
                    _DB.AddInParameter(_ObjCmd, "@pInstallmanrNo", DbType.Int32, pInstallmanrNo);
                    _DB.AddInParameter(_ObjCmd, "@pPaidAmount", DbType.Decimal, pPaidAmount);
                    _DB.AddInParameter(_ObjCmd, "@pTotalFees", DbType.Decimal, pTotalFees);
                    _DB.AddInParameter(_ObjCmd, "@pPendingFees", DbType.Decimal, pPendingFees);
                    _DB.AddInParameter(_ObjCmd, "@pPaidDate", DbType.Date, pPaidDate);
                    _DB.AddInParameter(_ObjCmd, "@pPaidBy", DbType.String, pPaidBy);
                    _DB.AddInParameter(_ObjCmd, "@pChequeNo", DbType.String, pChequeNo);
                    _DB.AddInParameter(_ObjCmd, "@pBankOfCheque", DbType.String, pBankOfCheque);
                    _DB.AddInParameter(_ObjCmd, "@pDepositedAccountName", DbType.String, pDepositedAccountName);
                    _DB.AddInParameter(_ObjCmd, "@pChequeReceiveDate", DbType.Date, pChequeReceiveDate);
                    _DB.AddInParameter(_ObjCmd, "@pChequeRequestDate", DbType.Date, pChequeRequestDate);
                    _DB.AddInParameter(_ObjCmd, "@pChequeAcceptDate", DbType.Date, pChequeAcceptDate);
                    _DB.AddInParameter(_ObjCmd, "@pChequeBounsDate", DbType.Date, pChequeBounsDate);
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

        //Update Cheque Details Data 
        public int SaveChequeDetails(int pReceiptId, string pReceiptNo, string pChequeNo, string pBankOfCheque, string pDepositedAccountName, DateTime? pChequeReceiveDate,
            DateTime? pChequeRequestDate, DateTime? pChequeAcceptDate, DateTime? pChequeBounsDate,
            int pUser, string pTerminal)
        {
            try
            {
                int ReceiptId = 0;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_StudentFeesDetails_SetChequeDetail"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pReceiptId", DbType.Int32, pReceiptId);
                    _DB.AddInParameter(_ObjCmd, "@pReceiptNo", DbType.String, pReceiptNo);
                    _DB.AddInParameter(_ObjCmd, "@pChequeNo", DbType.String, pChequeNo);
                    _DB.AddInParameter(_ObjCmd, "@pBankOfCheque", DbType.String, pBankOfCheque);
                    _DB.AddInParameter(_ObjCmd, "@pDepositedAccountName", DbType.String, pDepositedAccountName);
                    _DB.AddInParameter(_ObjCmd, "@pChequeReceiveDate", DbType.Date, pChequeReceiveDate);
                    _DB.AddInParameter(_ObjCmd, "@pChequeRequestDate", DbType.Date, pChequeRequestDate);
                    _DB.AddInParameter(_ObjCmd, "@pChequeAcceptDate", DbType.Date, pChequeAcceptDate);
                    _DB.AddInParameter(_ObjCmd, "@pChequeBounsDate", DbType.Date, pChequeBounsDate);
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
        public DataTable GeStudentFeesDetails(int? pReceiptId = null, int? pAdmissionId = null, string pPaidBy = null)
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_StudentFeesDetails_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pReceiptId", DbType.Int32, pReceiptId);
                    _DB.AddInParameter(_ObjCmd, "@pAdmissionId", DbType.Int32, pAdmissionId);
                    _DB.AddInParameter(_ObjCmd, "@pPaidBy ", DbType.String, pPaidBy);
                    _DT = _DB.ExecuteDataSet(_ObjCmd).Tables[0];
                }

                return _DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retrive Student Fees Data Base on Admission ID 
        public DataTable GeStudentFeesDetailsBaseOnAdmission(int pAdmissionId)
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_StudentFeesDetailBaseOnAdmission_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pAdmissionId", DbType.Int32, pAdmissionId);
                    _DT = _DB.ExecuteDataSet(_ObjCmd).Tables[0];
                }

                return _DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //Get Installment Details
        public DataTable GetInstallmentDetails(DateTime? FromDate = null, DateTime? ToDate = null)
        {
            try
            {
                DataTable _DT = new DataTable();
                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_FeeInstallmentDetail_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pFromDate", DbType.Date, FromDate);
                    _DB.AddInParameter(_ObjCmd, "@pToDate", DbType.Date, ToDate);

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
