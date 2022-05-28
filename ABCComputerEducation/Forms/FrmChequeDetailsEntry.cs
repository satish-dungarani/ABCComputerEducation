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
    public partial class FrmChequeDetailsEntry : DevExpress.XtraEditors.XtraForm
    {
        StudentFeesDetailsBLL _ObjStudentFeesDetailsBLL;
        public FrmChequeDetailsEntry()
        {
            InitializeComponent();
            _ObjStudentFeesDetailsBLL = new StudentFeesDetailsBLL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Send Data For Store In DB
                _ObjStudentFeesDetailsBLL.ReceiptId = Convert.ToInt32(this.txtReceiptId.Text);
                _ObjStudentFeesDetailsBLL.ReceiptNo = this.txtReceiptNo.Text;
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
                _ReceiptId = _ObjStudentFeesDetailsBLL.SetChequeDetails();
                if (_ReceiptId > 0)
                {
                    if (this.txtReceiptId.Text != "0")
                        HelperCls.MsgBox("Cheque Detail successfully updated.", HelperCls.MessageType.Success);

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                    HelperCls.MsgBox("Cheque Detail fail to update.", HelperCls.MessageType.Warning);
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
    }
}