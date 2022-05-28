using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCComputerEducation.DAL;
using System.Data;

namespace ABCComputerEducation.BLL
{
    public class StudentMasterBLL : BaseBLL
    {
        StudentMastersDAL _ObjStudentMastersDAL = new StudentMastersDAL();

        #region Properites

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Pincode { get; set; }
        public string ContactNo { get; set; }
        public decimal PersonalNo { get; set; }
        public decimal FatherContactNo { get; set; }
        public string RecidentialNo { get; set; }
        public string EmailId { get; set; }
        public string LastEducation { get; set; }
        public Nullable<int> InsUser { get; set; }
        public Nullable<DateTime> InsDateTime { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<DateTime> UpdDateTime { get; set; }
        public string UpdTerminal { get; set; }
        #endregion

        #region Operational Funcations
        //Save Data
        public int SetStudentMaster()
        {
            try
            {
                return _ObjStudentMastersDAL.SaveStudentMaster(StudentId,StudentName,Gender,Address,City,State,
                            Pincode, ContactNo, PersonalNo, FatherContactNo, RecidentialNo, EmailId, LastEducation, this.User, this.Terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Data
        public DataTable GetStudentMaster(int? pStudentId = null)
        {
            try
            {
                return _ObjStudentMastersDAL.GeStudenttMaster(pStudentId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
