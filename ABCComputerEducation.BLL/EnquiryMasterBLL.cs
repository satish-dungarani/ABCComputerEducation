using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCComputerEducation.DAL;
using System.Data;

namespace ABCComputerEducation.BLL
{
    public class EnquiryMasterBLL : BaseBLL
    {
        EnquiryMasterDAL _ObjEnquiryMastersDAL = new EnquiryMasterDAL();

        #region Properites

        public int EnquiryId { get; set; }
        public string EnquiryNo { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string No { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal? Pincode { get; set; }
        public string ContactNo { get; set; }
        public decimal? FatherContactNo { get; set; }
        public string RecidentialNo { get; set; }
        public string EmailId { get; set; }
        public int RefMasterValues_CourseId { get; set; }
        public string LastEducation { get; set; }
        public string Institution { get; set; }
        public string Examination { get; set; }
        public string CourseName { get; set; }
        public DateTime EnquiryDate { get; set; }
        public bool IsExternalData { get; set; }
        public Nullable<int> InsUser { get; set; }
        public Nullable<DateTime> InsDateTime { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<DateTime> UpdDateTime { get; set; }
        public string UpdTerminal { get; set; }
        #endregion

        #region Operational Funcations
        //Save Data
        public int SetEnquiryMaster()
        {
            try
            {
                return _ObjEnquiryMastersDAL.SaveEnquiryMaster(EnquiryId, EnquiryNo, StudentName, Gender, No, Address, City, State,
            Pincode,ContactNo, FatherContactNo, RecidentialNo, EmailId, RefMasterValues_CourseId, LastEducation,
            Institution, Examination,EnquiryDate, IsExternalData, User, Terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Data
        public DataTable GetEnquiryMaster(int? pEnquiryId = null, bool pIsExternalData = false)
        {
            try
            {
                return _ObjEnquiryMastersDAL.GeEnquirytMaster(pEnquiryId, pIsExternalData );
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
