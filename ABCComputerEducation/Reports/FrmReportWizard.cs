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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using ABCComputerEducation.Reports;
using ABCComputerEducation.BLL;
using ABCComputerEducation.DataSets;

namespace ABCComputerEducation.Reports
{
    public partial class FrmReportWizard : DevExpress.XtraEditors.XtraForm
    {
        StudentFeesDetailsBLL _ObjStudentFeesDetailsBLL = new StudentFeesDetailsBLL();
        public FrmReportWizard()
        {
            InitializeComponent();
            
        }

        private void FrmReportWizard_Load(object sender, EventArgs e)
        {
            try
            {
                //DataSet _DS = new DataSet();
                //DataTable _DT = new DataTable();
                //_DT = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails(null);
                ////_DS.Tables.Add(_DT);
                ////_DS.Tables[0].TableName = "FeeReceipt";
                //ReportDocument RPTDoc = new ReportDocument();
                ////RPTFeeReceipt _RPTFeeRec = new RPTFeeReceipt();
                //string ReportPath = Application.StartupPath.ToString() + "/Reports/RPTFeeReceipt.rpt";
                //RPTDoc.Load(ReportPath);
                //RPTDoc.SetDataSource(_DT);
                //this.crystalReportViewer1.ReportSource = RPTDoc;
                //XtraReport2 _XTR = new XtraReport2();
                //documentViewer1.DocumentSource = _XTR;
                //_XTR.CreateDocument();
                //this.crystalReportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}