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
    public class EnquiryMasterDAL : BaseDAL
    {
        
        //Insert And Update Enquiry Master Data 
        public int SaveEnquiryMaster(int pEnquiryId, string pEnquiryNo,string pStudentName, string pGender, string pNo, string pAddress, string pCity, string pState,
            decimal? pPincode,string pContactNo, decimal? pFatherContactNo, string pRecidentialNo, string pEmailId, int pRefMasterValues_CourseId, string pLastEducation,
            string pInstitution, string pExamination,DateTime pEnquiryDate, bool pIsExternalData, int pUser, string pTerminal)
        {
            try
            {
                int EnquiryId = 0;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_EnquiryMaster_Set"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pEnquiryId", DbType.Int32, pEnquiryId);
                    _DB.AddInParameter(_ObjCmd, "@pEnquiryNo", DbType.String, pEnquiryNo);
                    _DB.AddInParameter(_ObjCmd, "@pStudentName", DbType.String, pStudentName);
                    _DB.AddInParameter(_ObjCmd, "@pGender", DbType.String, pGender);
                    _DB.AddInParameter(_ObjCmd, "@pNo", DbType.String, pNo);
                    _DB.AddInParameter(_ObjCmd, "@pAddress", DbType.String, pAddress);
                    _DB.AddInParameter(_ObjCmd, "@pCity", DbType.String, pCity);
                    _DB.AddInParameter(_ObjCmd, "@pState", DbType.String, pState);
                    _DB.AddInParameter(_ObjCmd, "@pPincode", DbType.Decimal, pPincode);
                    _DB.AddInParameter(_ObjCmd, "@pContactNo", DbType.String, pContactNo);
                    _DB.AddInParameter(_ObjCmd, "@pFatherContactNo", DbType.Decimal, pFatherContactNo);
                    _DB.AddInParameter(_ObjCmd, "@pRecidentialNo", DbType.String, pRecidentialNo);
                    _DB.AddInParameter(_ObjCmd, "@pEmailId", DbType.String, pEmailId);
                    _DB.AddInParameter(_ObjCmd, "@pRefMasterValues_CourseId", DbType.Int32, pRefMasterValues_CourseId);
                    _DB.AddInParameter(_ObjCmd, "@pLastEducation", DbType.String, pLastEducation);
                    _DB.AddInParameter(_ObjCmd, "@pInstitution", DbType.String, pInstitution);
                    _DB.AddInParameter(_ObjCmd, "@pExamination ", DbType.String, pExamination);
                    _DB.AddInParameter(_ObjCmd, "@pEnquiryDate", DbType.Date, pEnquiryDate);
                    _DB.AddInParameter(_ObjCmd, "@pIsExternalData", DbType.Boolean, pIsExternalData);
                    _DB.AddInParameter(_ObjCmd, "@pUser", DbType.Int32, pUser);
                    _DB.AddInParameter(_ObjCmd, "@pTerminal", DbType.String, pTerminal);
                    EnquiryId = Convert.ToInt32(_DB.ExecuteScalar(_ObjCmd));
                }

                return EnquiryId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retrive Enquiry Master Data Base on EnquiryId or All
        public DataTable GeEnquirytMaster(int? pEnquiryId = null, bool pIsExternalData = false)
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_EnquiryMaster_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pEnquiryId", DbType.Int32, pEnquiryId);
                    _DB.AddInParameter(_ObjCmd, "@pIsExternalData", DbType.Boolean, pIsExternalData);
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
