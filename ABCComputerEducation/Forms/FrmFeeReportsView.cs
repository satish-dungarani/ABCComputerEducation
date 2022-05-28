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
    public partial class FrmFeeReportsView : DevExpress.XtraEditors.XtraForm
    {
        StudentFeesDetailsBLL _ObjStudentFeesDetailsBLL = new StudentFeesDetailsBLL();
        public FrmFeeReportsView()
        {
            InitializeComponent();
        }

        //private void btnFilter_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int? _BatchNo = null;
        //        if (this.cmbBatchNo.EditValue != null && this.cmbBatchNo.EditValue != "")
        //            _BatchNo = Convert.ToInt32(this.cmbBatchNo.EditValue);
        //        DateTime? _FromDate = null;
        //        if (this.dtpFromDate.Text != null && this.dtpFromDate.Text != "")
        //            _FromDate = Convert.ToDateTime(this.dtpFromDate.Text);
        //        DateTime? _ToDate = null;
        //        if (this.dtpToDate.Text != null && this.dtpToDate.Text != "")
        //            _ToDate = Convert.ToDateTime(this.dtpToDate.Text);

        //        this.GC_InstallmentDetail.DataSource = _ObjStudentFeesDetailsBLL.GetInstallmentDetails(_FromDate, _ToDate);
        //        this.GV_InstallmentDetail.BestFitColumns();
        //    }
        //    catch (Exception ex)
        //    {

        //        HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
        //    }
        //}

        private void FrmFeeReportsView_Load(object sender, EventArgs e)
        {
            try
            {
                AdmissionDetailBLL _ObjAdmissionDetailBLL = new AdmissionDetailBLL();
                GC_InstallmentDetail.DataSource = _ObjAdmissionDetailBLL.GetAllAdmissionDetail();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}