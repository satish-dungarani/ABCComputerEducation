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
using ABCComputerEducation.Reports;
using ABCComputerEducation.DataSets;
using ABCComputerEducation.BLL;

namespace ABCComputerEducation.Forms
{
    public partial class FrmStudentFeesDetailsEntry : DevExpress.XtraEditors.XtraForm
    {
        StudentFeesDetailsBLL _ObjStudentFeesDetailsBLL;
        MasterValuesBLL _ObjMasterValuesBLL;

        public FrmStudentFeesDetailsEntry()
        {
            InitializeComponent();

            _ObjStudentFeesDetailsBLL = new StudentFeesDetailsBLL();
            _ObjMasterValuesBLL = new MasterValuesBLL();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                decimal _decOut;
                DateTime _dtout;
                int _intOut;
                //Validation
                if (string.IsNullOrEmpty(this.txtReceiptNo.Text))
                {
                    HelperCls.MsgBox("Receipt No can't left blank.", HelperCls.MessageType.Warning);
                    this.txtReceiptNo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.ddlAdmissionId.Text))
                {
                    HelperCls.MsgBox("Admission Detail can't left blank.", HelperCls.MessageType.Warning);
                    this.ddlAdmissionId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.txtPaidAmount.Text))
                {
                    HelperCls.MsgBox("Paid Amount can't left blank.", HelperCls.MessageType.Warning);
                    this.txtPaidAmount.Focus();
                    return;
                }
                if (!decimal.TryParse(this.txtPaidAmount.Text, out _decOut))
                {
                    HelperCls.MsgBox("Paid Amount must be in numeric.", HelperCls.MessageType.Warning);
                    this.txtPaidAmount.Focus();
                    return;
                }
                if (Convert.ToDecimal(this.txtPaidAmount.Text) <= 0)
                {
                    HelperCls.MsgBox("Paid Amount must be grate than zero.", HelperCls.MessageType.Warning);
                    this.txtPaidAmount.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.dtpPaidDate.Text))
                {
                    HelperCls.MsgBox("Paid Date can't left blank.", HelperCls.MessageType.Warning);
                    this.dtpPaidDate.Focus();
                    return;
                }
                if (!DateTime.TryParse(this.dtpPaidDate.Text, out _dtout))
                {
                    HelperCls.MsgBox("Paid Date must be in Date format.", HelperCls.MessageType.Warning);
                    this.dtpPaidDate.Focus();
                    return;
                }
                if (!int.TryParse(this.txtInstallmentNo.Text, out _intOut))
                {
                    HelperCls.MsgBox("Installment No must be in number format.", HelperCls.MessageType.Warning);
                    this.txtInstallmentNo.Focus();
                    return;
                }
                if (Convert.ToDecimal(this.txtAlreadypaidfees.Text) == Convert.ToDecimal(this.txtTotalFees.Text))
                {
                    HelperCls.MsgBox("Fees Installment is completed. No more Installments available!", HelperCls.MessageType.Warning);
                    return;
                }

                if (this.cmbPaidBy.Text == "Cheque")
                {
                    if (string.IsNullOrEmpty(this.txtChequeNo.Text))
                    {
                        HelperCls.MsgBox("Cheque No can not left blank.", HelperCls.MessageType.Warning);
                        this.txtChequeNo.Focus();
                        return;
                    }
                    if (string.IsNullOrEmpty(this.txtBankofCheque.Text))
                    {
                        HelperCls.MsgBox("Received Cheque Bank name can not left blank.", HelperCls.MessageType.Warning);
                        this.txtBankofCheque.Focus();
                        return;
                    }
                }


                //Send Data For Store In DB
                _ObjStudentFeesDetailsBLL.ReceiptId = Convert.ToInt32(this.txtReceiptId.Text);
                _ObjStudentFeesDetailsBLL.ReceiptNo = this.txtReceiptNo.Text;
                _ObjStudentFeesDetailsBLL.RefAdmirssionDetail_AdmissionId = Convert.ToInt32(this.ddlAdmissionId.EditValue);
                _ObjStudentFeesDetailsBLL.InstallmanrNo = Convert.ToInt32(this.txtInstallmentNo.Text);
                _ObjStudentFeesDetailsBLL.PaidAmount = Convert.ToDecimal(this.txtPaidAmount.Text);
                _ObjStudentFeesDetailsBLL.TotalFees = Convert.ToDecimal(this.txtTotalFees.Text);
                _ObjStudentFeesDetailsBLL.PendingFees = Convert.ToDecimal(this.txtPendingFees.Text);
                _ObjStudentFeesDetailsBLL.PaidDate = Convert.ToDateTime(this.dtpPaidDate.EditValue);
                _ObjStudentFeesDetailsBLL.PaidBy = this.cmbPaidBy.Text;
                _ObjStudentFeesDetailsBLL.ChequeNo = this.txtChequeNo.Text;
                _ObjStudentFeesDetailsBLL.BankOfCheque = this.txtBankofCheque.Text;
                _ObjStudentFeesDetailsBLL.DepositedAccountName = this.txtDepositedAccName.Text;
                if (this.dtpReceiveDate.EditValue != null)
                    _ObjStudentFeesDetailsBLL.ChequeReceiveDate = Convert.ToDateTime(this.dtpReceiveDate.EditValue);
                if (this.dtpDepositedDate.EditValue != null)
                    _ObjStudentFeesDetailsBLL.ChequeRequestDate = Convert.ToDateTime(this.dtpDepositedDate.EditValue);
                if (this.dtpClearDate.EditValue != null)
                    _ObjStudentFeesDetailsBLL.ChequeAcceptDate = Convert.ToDateTime(this.dtpClearDate.EditValue);
                if (this.dtpBouncedDate.EditValue != null)
                    _ObjStudentFeesDetailsBLL.ChequeBounsDate = Convert.ToDateTime(this.dtpBouncedDate.EditValue);
                _ObjStudentFeesDetailsBLL.User = HelperCls.User;
                _ObjStudentFeesDetailsBLL.Terminal = HelperCls.Terminal;

                int _ReceiptId = 0;
                _ReceiptId = _ObjStudentFeesDetailsBLL.SetStudentFeesDetails();
                if (_ReceiptId > 0)
                {
                    if (this.txtReceiptId.Text == "0")
                        HelperCls.MsgBox("Student Fee Receipt successfully generated.", HelperCls.MessageType.Success);
                    else
                        HelperCls.MsgBox("Student Fees Detail successfully updated.", HelperCls.MessageType.Success);

                    FrmReportWizard _FrmWizard = new FrmReportWizard();
                    DataSet _DS = new DataSet();
                    //_DS.Tables.Add(new DataTable());
                    RPTFeeReceipt _ObjRPTFee = new RPTFeeReceipt();
                    DataTable _DT = new DataTable();
                    _DT = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails(_ReceiptId);

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

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                    HelperCls.MsgBox("Student Fees Detail fail to add or change.", HelperCls.MessageType.Warning);
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmStudentFeesDetailsEntry_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void ddlAdmissionId_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.SLV_Admission.GetRowCellValue(this.SLV_Admission.FocusedRowHandle, "StudentName") != null)
                {
                    this.txtStudentName.Text = this.SLV_Admission.GetRowCellValue(this.SLV_Admission.FocusedRowHandle, "StudentName").ToString();
                }

                _ObjStudentFeesDetailsBLL = new StudentFeesDetailsBLL();
                DataTable _DTAdmissionFeesInfo = new DataTable();
                _DTAdmissionFeesInfo = _ObjStudentFeesDetailsBLL.GetStudentFeesDetailsBaseOnAdmission(Convert.ToInt32(this.ddlAdmissionId.EditValue));
                if (_DTAdmissionFeesInfo.Rows.Count == 1)
                {
                    this.txtInstallmentNo.Text = _DTAdmissionFeesInfo.Rows[0]["InstallmentNo"].ToString();
                    this.txtAlreadypaidfees.Text = _DTAdmissionFeesInfo.Rows[0]["AlreadyPaidAmount"].ToString();
                    this.txtTotalFees.Text = _DTAdmissionFeesInfo.Rows[0]["TotalFees"].ToString();
                    if ((!string.IsNullOrEmpty(this.txtTotalFees.Text) && !string.IsNullOrEmpty(this.txtAlreadypaidfees.Text)) && (Convert.ToDecimal(this.txtTotalFees.Text) == Convert.ToDecimal(this.txtAlreadypaidfees.Text)))
                    {
                        this.txtPaidAmount.Properties.ReadOnly = true;
                    }
                    else
                    {
                        if (HelperCls._Action != "Edit")
                        {
                            decimal _PaidAmount = 0;
                            if (Convert.ToInt32(_DTAdmissionFeesInfo.Rows[0]["NoOfInstallments"].ToString()) > 0)
                                _PaidAmount = (Convert.ToDecimal(_DTAdmissionFeesInfo.Rows[0]["TotalFees"].ToString()) / Convert.ToInt32(_DTAdmissionFeesInfo.Rows[0]["NoOfInstallments"].ToString()));
                            if (_PaidAmount > (Convert.ToDecimal(this.txtTotalFees.Text) - Convert.ToDecimal(this.txtAlreadypaidfees.Text)))
                                _PaidAmount = (Convert.ToDecimal(this.txtTotalFees.Text) - Convert.ToDecimal(this.txtAlreadypaidfees.Text));
                            this.txtPaidAmount.Text = Math.Ceiling(_PaidAmount).ToString();
                            this.txtPendingFees.Text = (Convert.ToDecimal(this.txtTotalFees.Text) - (Convert.ToDecimal(this.txtPaidAmount.Text) + Convert.ToDecimal(this.txtAlreadypaidfees.Text))).ToString();
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void txtPaidAmount_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(this.txtTotalFees.Text) && !string.IsNullOrEmpty(this.txtAlreadypaidfees.Text))
                {
                    decimal _PaidAmount = 0;
                    if (decimal.TryParse(this.txtPaidAmount.Text, out _PaidAmount))
                    {
                        //if (_PaidAmount > (Convert.ToDecimal(this.txtTotalFees.Text) - Convert.ToDecimal(this.txtAlreadypaidfees.Text)))
                        //    _PaidAmount = (Convert.ToDecimal(this.txtTotalFees.Text) - Convert.ToDecimal(this.txtAlreadypaidfees.Text));
                        //this.txtPaidAmount.Text = Math.Ceiling(_PaidAmount).ToString();

                        if (HelperCls._Action.ToLower().Trim() == "edit" && this.txtEditPaidFee.Text != "0")
                            this.txtPendingFees.Text = (Convert.ToDecimal(this.txtTotalFees.Text) - (Convert.ToDecimal(this.txtAlreadypaidfees.Text) - Convert.ToDecimal(this.txtEditPaidFee.Text) + Convert.ToDecimal(this.txtPaidAmount.Text))).ToString();
                        else
                            this.txtPendingFees.Text = (Convert.ToDecimal(this.txtTotalFees.Text) - (Convert.ToDecimal(this.txtPaidAmount.Text) + Convert.ToDecimal(this.txtAlreadypaidfees.Text))).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void cmbPaidBy_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cmbPaidBy.Text == "Cheque")
                {
                    ManageChequeInfo(true);
                    this.dtpReceiveDate.Text = DateTime.Now.ToShortDateString();
                }
                else
                {
                    ManageChequeInfo();
                    this.dtpReceiveDate.Text = "";
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        public void ManageChequeInfo(bool _IsVisible = false)
        {
            try
            {
                this.lblChequeNo.Visible = _IsVisible;
                this.txtChequeNo.Visible = _IsVisible;
                this.lblDAccName.Visible = _IsVisible;
                this.txtDepositedAccName.Visible = _IsVisible;
                this.lblBankofCheque.Visible = _IsVisible;
                this.txtBankofCheque.Visible = _IsVisible;
                this.lblReceiveDate.Visible = _IsVisible;
                this.dtpReceiveDate.Visible = _IsVisible;
                this.lblDepositedDate.Visible = _IsVisible;
                this.dtpDepositedDate.Visible = _IsVisible;
                this.lblClearDate.Visible = _IsVisible;
                this.dtpClearDate.Visible = _IsVisible;
                this.lblBouncedDate.Visible = _IsVisible;
                this.dtpBouncedDate.Visible = _IsVisible;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}