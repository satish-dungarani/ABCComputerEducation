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
using ABCComputerEducation.Reports;
using ABCComputerEducation.DataSets;

namespace ABCComputerEducation.Forms
{
    public partial class FrmStudentFeesDetails : DevExpress.XtraEditors.XtraForm
    {
        StudentFeesDetailsBLL _ObjStudentFeesDetailsBLL;
        FrmStudentFeesDetailsEntry _ObjStudentFeesDetailsEntry;
        StudentMasterBLL _ObjStudentMasterBLL;
        AdmissionDetailBLL _ObjAdmissionDetailBLL;
        public FrmStudentFeesDetails()
        {
            InitializeComponent();
            _ObjStudentFeesDetailsBLL = new StudentFeesDetailsBLL();
        }

        private void RIBEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                _ObjStudentFeesDetailsEntry = new FrmStudentFeesDetailsEntry();
                BindController(_ObjStudentFeesDetailsEntry);
                _ObjStudentFeesDetailsEntry.lblTitle.Text = "Edit Student Fee Detail";

                HelperCls._Action = "Edit";
                DataTable _DT = new DataTable();
                _DT = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails(Convert.ToInt32(this.GVStudentFeesDetails.GetFocusedRowCellValue("ReceiptId").ToString()));
                _ObjStudentFeesDetailsEntry.txtReceiptId.Text = _DT.Rows[0]["ReceiptId"].ToString();
                _ObjStudentFeesDetailsEntry.txtReceiptNo.Text = _DT.Rows[0]["ReceiptNo"].ToString();
                _ObjStudentFeesDetailsEntry.ddlAdmissionId.EditValue = _DT.Rows[0]["RefAdmirssionDetail_AdmissionId"].ToString();
                _ObjStudentFeesDetailsEntry.txtStudentName.Text = _DT.Rows[0]["StudentName"].ToString();
                _ObjStudentFeesDetailsEntry.txtInstallmentNo.Text = _DT.Rows[0]["InstallmanrNo"].ToString();
                _ObjStudentFeesDetailsEntry.txtPaidAmount.Text = _DT.Rows[0]["PaidAmount"].ToString();
                _ObjStudentFeesDetailsEntry.txtEditPaidFee.Text = _DT.Rows[0]["PaidAmount"].ToString();
                _ObjStudentFeesDetailsEntry.txtPendingFees.Text = _DT.Rows[0]["PendingFees"].ToString();
                _ObjStudentFeesDetailsEntry.txtTotalFees.Text = _DT.Rows[0]["TotalFees"].ToString();
                _ObjStudentFeesDetailsEntry.dtpPaidDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["PaidDate"].ToString());
                _ObjStudentFeesDetailsEntry.txtChequeNo.Text = _DT.Rows[0]["ChequeNo"].ToString();
                _ObjStudentFeesDetailsEntry.txtBankofCheque.Text = _DT.Rows[0]["BankofCheque"].ToString();
                _ObjStudentFeesDetailsEntry.txtDepositedAccName.Text = _DT.Rows[0]["DepositedAccountName"].ToString();
                if (!string.IsNullOrEmpty(_DT.Rows[0]["ChequeReceiveDate"].ToString()))
                    _ObjStudentFeesDetailsEntry.dtpReceiveDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["ChequeReceiveDate"].ToString());
                if (!string.IsNullOrEmpty(_DT.Rows[0]["ChequeRequestDate"].ToString()))
                    _ObjStudentFeesDetailsEntry.dtpDepositedDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["ChequeRequestDate"].ToString());
                if (!string.IsNullOrEmpty(_DT.Rows[0]["ChequeAcceptDate"].ToString()))
                    _ObjStudentFeesDetailsEntry.dtpClearDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["ChequeAcceptDate"].ToString());
                if (!string.IsNullOrEmpty(_DT.Rows[0]["ChequeBounsDate"].ToString()))
                    _ObjStudentFeesDetailsEntry.dtpBouncedDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["ChequeBounsDate"].ToString());

                if (_ObjStudentFeesDetailsEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjStudentFeesDetailsEntry.Close();
                    //Binding Grid View
                    this.GCStudentFeesDetails.DataSource = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails();
                    this.GVStudentFeesDetails.BestFitColumns(true);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void RIBDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (HelperCls.MsgBox("Are you sure to delete Student Fees Detail?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int ReceiptId = Convert.ToInt32(this.GVStudentFeesDetails.GetFocusedRowCellValue("ReceiptId"));
                    if (_ObjStudentFeesDetailsBLL.DeleteRecord(ReceiptId, "StudentFeesDetails") > 0)
                    {
                        HelperCls.MsgBox("Student Fees Detail successfully deleted!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCStudentFeesDetails.DataSource = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails();
                        this.GVStudentFeesDetails.BestFitColumns(true);
                    }
                    else
                        HelperCls.MsgBox("Somthing want wrong! Student Fees Record delete fail!", HelperCls.MessageType.Warning);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                _ObjStudentFeesDetailsEntry = new FrmStudentFeesDetailsEntry();
                BindController(_ObjStudentFeesDetailsEntry);
                _ObjStudentFeesDetailsEntry.lblTitle.Text = "Add Student Fee Installment";

                HelperCls._Action = "Add";
                StudentMasterBLL _ObjStudentMasterBLL = new StudentMasterBLL();

                _ObjStudentFeesDetailsEntry.txtReceiptId.Text = "0";
                _ObjStudentFeesDetailsEntry.txtReceiptNo.Text = _ObjStudentMasterBLL.GetSequanceNo("Fees").ToString();
                //_ObjStudentFeesDetailsEntry.ddlAdmissionId.EditValue = -1;
                _ObjStudentFeesDetailsEntry.txtInstallmentNo.Text = "";
                _ObjStudentFeesDetailsEntry.txtPaidAmount.Text = "";
                _ObjStudentFeesDetailsEntry.dtpPaidDate.Text = DateTime.Now.ToShortDateString();
                _ObjStudentFeesDetailsEntry.txtPendingFees.Text = "";
                _ObjStudentFeesDetailsEntry.txtTotalFees.Text = "";


                if (_ObjStudentFeesDetailsEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjStudentFeesDetailsEntry.Close();
                    //Binding Grid View
                    this.GCStudentFeesDetails.DataSource = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails();
                    this.GVStudentFeesDetails.BestFitColumns(true);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmStudentFeesDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (HelperCls.UserName.ToLower().Trim() == "user")
                {
                    this.GCOLDeleteAction.Visible = false;
                }
                //Binding Grid View
                this.GCStudentFeesDetails.DataSource = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails();
                this.GVStudentFeesDetails.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        public void BindController(FrmStudentFeesDetailsEntry _Obj)
        {
            try
            {
                #region "Bind Dropdown Controll"
                //Admission Detail
                _ObjAdmissionDetailBLL = new AdmissionDetailBLL();
                DataTable _DTAdmission = new DataTable();
                _DTAdmission = _ObjAdmissionDetailBLL.GetAdmissionDetail(null);

                _Obj.ddlAdmissionId.Properties.DataSource = _DTAdmission;
                _Obj.ddlAdmissionId.Properties.ValueMember = "AdmissionId";
                _Obj.ddlAdmissionId.Properties.DisplayMember = "AdmissionCode";
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void RIBReport_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                FrmReportWizard _FrmWizard = new FrmReportWizard();
                DataSet _DS = new DataSet();

                RPTFeeReceipt _ObjRPTFee = new RPTFeeReceipt();
                DataTable _DT = new DataTable();
                _DT = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails(Convert.ToInt32(this.GVStudentFeesDetails.GetRowCellValue(this.GVStudentFeesDetails.FocusedRowHandle, "ReceiptId").ToString()));

                _DS.Tables.Add(_DT.Copy());
                _DS.Tables[0].TableName = "FeeReceipt";
                //_DS.Tables[0].Rows.Add();
                //_DS.Tables[0].Rows[0]["ReceiptId"] = _DT.Rows[0]["ReceiptId"];
                //_DS.Tables[0].Rows[0]["ReceiptNo"] = _DT.Rows[0]["ReceiptNo"];
                //_DS.Tables[0].Rows[0]["StudentName"] = _DT.Rows[0]["StudentName"];
                //_DS.Tables[0].Rows[0]["InstallmentNo"] = _DT.Rows[0]["InstallmanrNo"];
                //_DS.Tables[0].Rows[0]["PaidDate"] = _DT.Rows[0]["PaidDate"];
                //_DS.Tables[0].Rows[0]["PaidAmount"] = _DT.Rows[0]["PaidAmount"];
                //_DS.Tables[0].Rows[0]["TotalFees"] = _DT.Rows[0]["TotalFees"];

                InstituteBLL _ObjInstituteBLL = new InstituteBLL();
                _DS.Tables.Add(_ObjInstituteBLL.GetInstituteInfo().Copy());

                _DS.Tables[1].TableName = "InstituteMaster";

                _FrmWizard.crystalReportViewer1.ReportSource = _ObjRPTFee;
                _ObjRPTFee.Load();
                _ObjRPTFee.SetDataSource(_DS);
                _FrmWizard.crystalReportViewer1.Refresh();
                _FrmWizard.Show();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}