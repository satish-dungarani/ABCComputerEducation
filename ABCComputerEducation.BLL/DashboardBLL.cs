using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ABCComputerEducation.DAL;

namespace ABCComputerEducation.BLL
{
    public class DashboardBLL : BaseBLL
    {
        DashboardDAL _ObjDashboardDAL = new DashboardDAL();

        #region Dashboard Parameter
        public int TotalStudents { get; set; }
        public int TotalEnquiry { get; set; }
        public int TotalAdmission { get; set; }
        public int RGCSMAdmission { get; set; }
        public int ABCAdmission { get; set; }
        public int TotalCerty { get; set; }
        public int ReqCerty { get; set; }
        public int RecCerty { get; set; }
        public int IssueCerty { get; set; }

        #endregion

        public DataTable GetDashboardData()
        {
            try
            {
                DataTable _DT = new DataTable();
                DashboardBLL _Obj = new DashboardBLL();
                _DT  = _ObjDashboardDAL.GetDashBoardData().Tables[0];
                //_Obj.TotalStudents = Convert.ToInt32(_DT.Rows[0]["TotalStudents"].ToString());
                //_Obj.TotalEnquiry= Convert.ToInt32(_DT.Rows[0]["TotalEnquiry"].ToString());
                //_Obj.TotalAdmission= Convert.ToInt32(_DT.Rows[0]["TotalAdmission"].ToString());
                //_Obj.RGCSMAdmission  = Convert.ToInt32(_DT.Rows[0]["RGCSMAdmission"].ToString());
                //_Obj.ABCAdmission = Convert.ToInt32(_DT.Rows[0]["ABCAdmission"].ToString());
                //_Obj.TotalCerty = Convert.ToInt32(_DT.Rows[0]["TotalCery"].ToString());
                //_Obj.ReqCerty = Convert.ToInt32(_DT.Rows[0]["RequestCerty"].ToString());
                //_Obj.RecCerty= Convert.ToInt32(_DT.Rows[0]["ReceiveCerty"].ToString());
                //_Obj.IssueCerty = Convert.ToInt32(_DT.Rows[0]["IssueCerty"].ToString());
                return _DT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
