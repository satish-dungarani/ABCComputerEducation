using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ABCComputerEducation.BLL;

namespace ABCComputerEducation.Forms
{

    public partial class FrmDashboard : DevExpress.XtraEditors.XtraForm
    {
        DashboardBLL _ObjDashboardBLL = new DashboardBLL();
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable _DT = new DataTable ();
                 _DT = _ObjDashboardBLL.GetDashboardData();
                 lblStudentDet.Text = "\t Total Admission: " + Convert.ToInt32(_DT.Rows[0]["OverAllAdmission"].ToString()) + "\n\n" +
                            "\t\t Exam Done: " + Convert.ToInt32(_DT.Rows[0]["ExamDoneAdmission"].ToString()) + "\n\n" +
                            "\t\t Pass Out: " + Convert.ToInt32(_DT.Rows[0]["PassOutAdmission"].ToString()) + "\n\n" +
                            "\t\t Drop Out: " + Convert.ToInt32(_DT.Rows[0]["DropOutAdmission"].ToString());
                 lblEnquiryDet.Text = "\t Total Enquiry: " + Convert.ToInt32(_DT.Rows[0]["TotalEnquiry"].ToString()) + "\n\n" +
                             "\t\t Office Enquiry: " + Convert.ToInt32(_DT.Rows[0]["OfficeEnquiry"].ToString()) + "\n\n" +
                             "\t\t External Enquiry: " + Convert.ToInt32(_DT.Rows[0]["ExternalData"].ToString());
                lblAdmissionDet.Text = "\t Total Running Admission: " + Convert.ToInt32(_DT.Rows[0]["TotalAdmission"].ToString())+ "\n\n" +
                        "\t\t For RGCSM: " + Convert.ToInt32(_DT.Rows[0]["RGCSMAdmission"].ToString()) + "\n\n" +
                        "\t\t For ABC: " + Convert.ToInt32(_DT.Rows[0]["ABCAdmission"].ToString());
                lblCertyDet.Text = "\t Total Certy: " + Convert.ToInt32(_DT.Rows[0]["TotalCery"].ToString())+ "\n\n" +
                    "\t\t Requested Certy: " + Convert.ToInt32(_DT.Rows[0]["RequestCerty"].ToString()) + "\n\n" +
                    "\t\t Received Certy: " + Convert.ToInt32(_DT.Rows[0]["ReceiveCerty"].ToString()) + "\n\n" +
                    "\t\t Issued Certy: " + Convert.ToInt32(_DT.Rows[0]["IssueCerty"].ToString());

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}