using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABCComputerEducation.DAL;
using System.Data;

namespace ABCComputerEducation.BLL
{
    public class CertyRegistrationBLL : BaseBLL
    {
        CertyRegistrationDAL _ObjCertyRegistrationDAL = new CertyRegistrationDAL();

        #region Properites

        public int CertyId { get; set; }
        public string RegNo { get; set; }
        public int RefStudentExamMarkSheet_MarksheetId { get; set; }
        public DateTime RegDate { get; set; }
        public string CertyType { get; set; }
        public Nullable<DateTime> CertyRequestDate { get; set; }
        public Nullable<DateTime> CertyReceiveDate { get; set; }
        public Nullable<DateTime> CertyIssueDate { get; set; }
        public Nullable<int> InsUser { get; set; }
        public Nullable<DateTime> InsDateTime { get; set; }
        public string InsTerminal { get; set; }
        public Nullable<int> UpdUser { get; set; }
        public Nullable<DateTime> UpdDateTime { get; set; }
        public string UpdTerminal { get; set; }
        #endregion

        #region Operational Funcations
        //Save Data
        public int SetCertRegistration()
        {
            try
            {
                return _ObjCertyRegistrationDAL.SaveCertyRegistration(CertyId,RegNo,RefStudentExamMarkSheet_MarksheetId,RegDate,
                    CertyType,CertyRequestDate,CertyReceiveDate,CertyIssueDate,this.User, this.Terminal);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Get Data
        public DataTable GetCertRegistration(int? pCertyId = null)
        {
            try
            {
                return _ObjCertyRegistrationDAL.GeCertyRegistration(pCertyId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
