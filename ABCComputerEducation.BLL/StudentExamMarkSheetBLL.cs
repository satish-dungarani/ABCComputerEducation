using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCComputerEducation.DAL;
using System.Data;

namespace ABCComputerEducation.BLL
{
    public class StudentExamMarkSheetBLL : BaseBLL
    {
        StudentExamMarkSheetDAL _ObjStudentExamMarkSheetDAL = new StudentExamMarkSheetDAL();

        #region Properites

        public int MarkSheetId { get; set; }
        public string MarkSheetNo { get; set; }
        public int RefAdmissionMaster_AdmissionId { get; set; }
        public DateTime ExamDate { get; set; }
        public string ExamResult { get; set; }
        public Nullable<int> InsUser { get; set; }
        public Nullable<DateTime> InsDateTime { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<DateTime> UpdDateTime { get; set; }
        public string UpdTerminal { get; set; }
        #endregion

        #region Operational Funcations
        //Save Data
        public int SetStudentExamMarkSheet()
        {
            try
            {
                return _ObjStudentExamMarkSheetDAL.SaveStudentExamMarks(MarkSheetId,MarkSheetNo,RefAdmissionMaster_AdmissionId,
                    ExamDate,ExamResult,User, Terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Data
        public DataTable GetStudentExamMarkSheet(int? pMarkSheetId = null, DateTime? pMarkSheetDate = null, string pMarkSheetResult = null)
        {
            try
            {
                return _ObjStudentExamMarkSheetDAL.GeStudentExamMarks(pMarkSheetId, pMarkSheetDate, pMarkSheetResult);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
