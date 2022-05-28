using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCComputerEducation.DAL;
using System.Data;

namespace ABCComputerEducation.BLL
{
    public class AdmissionDetailBLL : BaseBLL
    {
        AdmissionDetailDAL _ObjAdmissionDetailDAL = new AdmissionDetailDAL();

        #region Properites

        public int AdmissionId { get; set; }
        public string AdmissionCode { get; set; }
        public int RefEnquiryMaster_EnquiryId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string No { get; set; }
        public string Address  { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Pincode { get; set; }
        public string ContactNo { get; set; }
        public decimal FatherContactNo { get; set; }
        public string RecidentialNo { get; set; }
        public string EmailId { get; set; }
        public string LastEducation { get; set; }
        public string Institution { get; set; }
        public string Examination { get; set; }
        public int RefMasterValues_CourseId { get; set; }
        public string CourseType { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public decimal CouseFee { get; set; }
        public int CouserTimePeriod { get; set; }
        public int NoOfInstallments { get; set; }
        public DateTime AdmissionDate { get; set; }
        public int? RefAdmissionId { get; set; }
        public string Lab{ get; set; }
        public bool IsDropOut { get; set; }
        public Nullable<int> InsUser { get; set; }
        public Nullable<DateTime> InsDateTime { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<DateTime> UpdDateTime { get; set; }
        public string UpdTerminal { get; set; }
        #endregion

        #region Operational Funcations
        //Save Data
        public int SetAdmissionDetail()
        {
            try
            {
                return _ObjAdmissionDetailDAL.SaveAdmissionDetail(AdmissionId,AdmissionCode,RefEnquiryMaster_EnquiryId,StudentName, Gender, EmailId,
                    No,Address,City,State, Pincode,ContactNo, FatherContactNo, RecidentialNo,
                    RefMasterValues_CourseId, CourseType, FromTime, ToTime, CouseFee, CouserTimePeriod, NoOfInstallments, AdmissionDate, RefAdmissionId, Lab, IsDropOut,
                     User, Terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Data
        public DataTable GetAdmissionDetail(int? pAdmissionId = null, bool pIsDropOut = false, bool pIsPassedOut = false, string pFromTime = null, string pToTime = null, string pLab = null)
        {
            try
            {
                return _ObjAdmissionDetailDAL.GeAdmissionDetail(pAdmissionId, pIsDropOut, pIsPassedOut, pFromTime, pToTime, pLab);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get Data
        public DataTable GetAllAdmissionDetail()
        {
            try
            {
                return _ObjAdmissionDetailDAL.GetAllAdmissionDetail();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get Time List
        public DataSet GetTimeAndLabList()
        {
            try
            {
                return _ObjAdmissionDetailDAL.GetFromToTimeAndLabList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Set Drop Out Status
        public bool SetDropOutStatus(int pAdmissionId , bool pIsDropOut )
        {
            try
            {
                return _ObjAdmissionDetailDAL.SetDropOutStatus(pAdmissionId, pIsDropOut);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        #endregion
    }
}
