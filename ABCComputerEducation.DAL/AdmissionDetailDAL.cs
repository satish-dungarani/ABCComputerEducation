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
    public class AdmissionDetailDAL : BaseDAL
    {
        //Insert And Update Admission Detail Data 
        public int SaveAdmissionDetail(int pAdmissionId, string pAdmissionCode, int pRefEnquiryMaster_EnquiryId, string pStudentName, string pGender,string pEmailId,
            string pNo, string pAddress,string  pCity, string pState , decimal pPincode, string pContactNo, decimal pFatherContactNo, string pRecidentialNo,
            int pRefMasterValues_CourseId, string pCourseType, string pFromTime, string pToTime, decimal pCouseFee,
            int pCouserTimePeriod, int pNoOfInstallments, DateTime pAdmissionDate, int? pRefAdmissionId, string pLab, bool pIsDropOut,
            int pUser, string pTerminal)
        {
            try
            {
                int AdmissionId = 0;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_AdmissionDetail_Set"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pAdmissionId", DbType.Int32, pAdmissionId);
                    _DB.AddInParameter(_ObjCmd, "@pAdmissionCode", DbType.String, pAdmissionCode);
                    _DB.AddInParameter(_ObjCmd, "@pRefEnquiryMaster_EnquiryId", DbType.Int32, pRefEnquiryMaster_EnquiryId);
                    _DB.AddInParameter(_ObjCmd, "@pStudentName", DbType.String, pStudentName);
                    _DB.AddInParameter(_ObjCmd, "@pGender", DbType.String, pGender);
                    _DB.AddInParameter(_ObjCmd, "@pEmailId", DbType.String, pEmailId);
                    _DB.AddInParameter(_ObjCmd, "@pNo", DbType.String, pNo);
                    _DB.AddInParameter(_ObjCmd, "@pAddress", DbType.String, pAddress);
                    _DB.AddInParameter(_ObjCmd, "@pCity", DbType.String, pCity);
                    _DB.AddInParameter(_ObjCmd, "@pState", DbType.String, pState);
                    _DB.AddInParameter(_ObjCmd, "@pPincode", DbType.String, pPincode);
                    _DB.AddInParameter(_ObjCmd, "@pContactNo", DbType.String, pContactNo);
                    _DB.AddInParameter(_ObjCmd, "@pFatherContactNo", DbType.Decimal, pFatherContactNo);
                    _DB.AddInParameter(_ObjCmd, "@pRecidentialNo", DbType.String, pRecidentialNo);
                    _DB.AddInParameter(_ObjCmd, "@pRefMasterValues_CourseId", DbType.Int32, pRefMasterValues_CourseId);
                    _DB.AddInParameter(_ObjCmd, "@pCourseType", DbType.String, pCourseType);
                    _DB.AddInParameter(_ObjCmd, "@pFromTime", DbType.String, pFromTime.ToString());
                    _DB.AddInParameter(_ObjCmd, "@pToTime", DbType.String, pToTime.ToString());
                    _DB.AddInParameter(_ObjCmd, "@pCouseFee", DbType.Decimal, pCouseFee);
                    _DB.AddInParameter(_ObjCmd, "@pCouserTimePeriod", DbType.Int32, pCouserTimePeriod);
                    _DB.AddInParameter(_ObjCmd, "@pNoOfInstallments", DbType.Int32, pNoOfInstallments);
                    _DB.AddInParameter(_ObjCmd, "@pAdmissionDate", DbType.Date, pAdmissionDate);
                    _DB.AddInParameter(_ObjCmd, "@pRefAdmissionId", DbType.Int32, pRefAdmissionId);
                    _DB.AddInParameter(_ObjCmd, "@pLab", DbType.String, pLab);
                    _DB.AddInParameter(_ObjCmd, "@pIsDropOut", DbType.Int32, pIsDropOut);
                    _DB.AddInParameter(_ObjCmd, "@pUser", DbType.Int32, pUser);
                    _DB.AddInParameter(_ObjCmd, "@pTerminal", DbType.String, pTerminal);
                    AdmissionId = Convert.ToInt32(_DB.ExecuteScalar(_ObjCmd));
                }

                return AdmissionId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retrive Admission Detail Data Base on Admission Id , Student ID , Course Id and Course Type or All
        public DataTable GeAdmissionDetail(int? pAdmissionId = null, bool pIsDropOut = false, bool pIsPassedOut = false,
            string pFromTime = null, string pToTime = null, string pLab = null, int? pRefStudentMaster_StudentId = null,
            int? pRefMasterValues_CourseId = null, string pCourseType = null, bool pIsDeleted = false)
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_AdmissionDetail_Get"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pAdmissionId", DbType.Int32, pAdmissionId);
                    _DB.AddInParameter(_ObjCmd, "@pRefStudentMaster_StudentId ", DbType.Int32, pRefStudentMaster_StudentId);
                    _DB.AddInParameter(_ObjCmd, "@pRefMasterValues_CourseId ", DbType.Int32, pRefMasterValues_CourseId);
                    _DB.AddInParameter(_ObjCmd, "@pCourseType", DbType.Int32, pCourseType);
                    _DB.AddInParameter(_ObjCmd, "@pIsDropOut ", DbType.Boolean, pIsDropOut);
                    _DB.AddInParameter(_ObjCmd, "@pIsPassedOut ", DbType.Boolean, pIsPassedOut);
                    _DB.AddInParameter(_ObjCmd, "@pIsDeleted", DbType.Boolean, pIsDeleted);
                    _DB.AddInParameter(_ObjCmd, "@pFromTime", DbType.String, pFromTime);
                    _DB.AddInParameter(_ObjCmd, "@pToTime", DbType.String, pToTime);
                    _DB.AddInParameter(_ObjCmd, "@pLab", DbType.String, pLab);
                    _DT = _DB.ExecuteDataSet(_ObjCmd).Tables[0];
                }

                return _DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Get All Admission
        public DataTable GetAllAdmissionDetail()
        {
            try
            {
                DataTable _DT = new DataTable();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_AdmissionDetail_All"))
                {
                    _DT = _DB.ExecuteDataSet(_ObjCmd).Tables[0];
                }

                return _DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetFromToTimeAndLabList()
        {
            try
            {
                DataSet _DS = new DataSet();

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_AdmissionDetail_GetFromToTimeList"))
                {
                    _DS = _DB.ExecuteDataSet(_ObjCmd);
                }

                return _DS;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Retrive Admission Detail Data Base on Admission Id , Student ID , Course Id and Course Type or All
        public bool SetDropOutStatus(int pAdmissionId, bool pIsDropOut)
        {
            try
            {
                bool _Result = false;

                Database _DB = new SqlDatabase(ConnectionString);
                using (DbCommand _ObjCmd = _DB.GetStoredProcCommand("sp_AdmissionDetail_SetStatus"))
                {
                    _DB.AddInParameter(_ObjCmd, "@pAdmissionId", DbType.Int32, pAdmissionId);
                    _DB.AddInParameter(_ObjCmd, "@pIsDropOut ", DbType.Boolean, pIsDropOut);
                    var _i = _DB.ExecuteNonQuery(_ObjCmd);
                    if (_i == -1)
                        _Result = true;
                }

                return _Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
