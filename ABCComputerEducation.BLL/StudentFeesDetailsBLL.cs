using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCComputerEducation.DAL;
using System.Data;

namespace ABCComputerEducation.BLL
{
    public class StudentFeesDetailsBLL : BaseBLL
    {
        StudentFeesDetailsDAL _ObjStudentFeesDetailsDAL = new StudentFeesDetailsDAL();

        #region Properites

        public int ReceiptId { get; set; }
        public string ReceiptNo { get; set; }
        public int RefAdmirssionDetail_AdmissionId { get; set; }
        public string StudentName { get; set; }
        public int InstallmanrNo { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal TotalFees { get; set; }
        public decimal PendingFees { get; set; }
        public DateTime PaidDate { get; set; }
        public string PaidBy { get; set; }
        public string ChequeNo { get; set; }
        public string BankOfCheque { get; set; }
        public string DepositedAccountName { get; set; }
        public DateTime? ChequeReceiveDate { get; set; }
        public DateTime? ChequeRequestDate { get; set; }
        public DateTime? ChequeAcceptDate { get; set; }
        public DateTime? ChequeBounsDate { get; set; }
        public Nullable<int> InsUser { get; set; }
        public Nullable<DateTime> InsDateTime { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<DateTime> UpdDateTime { get; set; }
        public string UpdTerminal { get; set; }
        #endregion

        #region Operational Funcations
        //Save Data
        public int SetStudentFeesDetails()
        {
            try
            {
                return _ObjStudentFeesDetailsDAL.SaveStudentFeesDetails(ReceiptId, ReceiptNo, RefAdmirssionDetail_AdmissionId,
                    InstallmanrNo, PaidAmount, TotalFees, PendingFees, PaidDate,
                    PaidBy, ChequeNo, BankOfCheque, DepositedAccountName, ChequeReceiveDate,
                    ChequeRequestDate, ChequeAcceptDate, ChequeBounsDate, User, Terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Save Cheque Data
        public int SetChequeDetails()
        {
            try
            {
                return _ObjStudentFeesDetailsDAL.SaveChequeDetails(ReceiptId, ReceiptNo, ChequeNo, BankOfCheque, DepositedAccountName, ChequeReceiveDate,
                    ChequeRequestDate, ChequeAcceptDate, ChequeBounsDate, User, Terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Data
        public DataTable GetStudentFeesDetails(int? pReceiptId = null,string pPaidBy = null)
        {
            try
            {
                return _ObjStudentFeesDetailsDAL.GeStudentFeesDetails(pReceiptId, null, pPaidBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Fees Information Data
        public DataTable GetStudentFeesDetailsBaseOnAdmission(int pAdmissionId)
        {
            try
            {
                return _ObjStudentFeesDetailsDAL.GeStudentFeesDetailsBaseOnAdmission(pAdmissionId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Get Installment Detail
        public DataTable GetInstallmentDetails( DateTime? FromDate = null, DateTime? ToDate = null)
        {
            try
            {
                return _ObjStudentFeesDetailsDAL.GetInstallmentDetails(FromDate, ToDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
