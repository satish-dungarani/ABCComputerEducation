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
    public partial class FrmChequeDetails : DevExpress.XtraEditors.XtraForm
    {
        StudentFeesDetailsBLL _ObjStudentFeesDetailsBLL;
        FrmChequeDetailsEntry _ObjChequeDetailsEntry;
        public FrmChequeDetails()
        {
            InitializeComponent();
            _ObjStudentFeesDetailsBLL = new StudentFeesDetailsBLL();
        }

        private void RIBEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                _ObjChequeDetailsEntry = new FrmChequeDetailsEntry();
                _ObjChequeDetailsEntry.lblTitle.Text = "Edit Cheque Detail";

                HelperCls._Action = "Edit";
                DataTable _DT = new DataTable();
                _DT = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails(Convert.ToInt32(this.GVChequeDetails.GetFocusedRowCellValue("ReceiptId").ToString()));
                _ObjChequeDetailsEntry.txtReceiptId.Text = _DT.Rows[0]["ReceiptId"].ToString();
                _ObjChequeDetailsEntry.txtReceiptNo.Text = _DT.Rows[0]["ReceiptNo"].ToString();

                _ObjChequeDetailsEntry.txtStudentName.Text = _DT.Rows[0]["StudentName"].ToString();
                _ObjChequeDetailsEntry.txtChequeNo.Text = _DT.Rows[0]["ChequeNo"].ToString();
                _ObjChequeDetailsEntry.txtBankofCheque.Text = _DT.Rows[0]["BankofCheque"].ToString();
                _ObjChequeDetailsEntry.txtDepositedAccName.Text = _DT.Rows[0]["DepositedAccountName"].ToString();
                if (!string.IsNullOrEmpty(_DT.Rows[0]["ChequeReceiveDate"].ToString()))
                    _ObjChequeDetailsEntry.dtpReceiveDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["ChequeReceiveDate"].ToString());
                if (!string.IsNullOrEmpty(_DT.Rows[0]["ChequeRequestDate"].ToString()))
                    _ObjChequeDetailsEntry.dtpDepositedDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["ChequeRequestDate"].ToString());
                if (!string.IsNullOrEmpty(_DT.Rows[0]["ChequeAcceptDate"].ToString()))
                    _ObjChequeDetailsEntry.dtpClearDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["ChequeAcceptDate"].ToString());
                if (!string.IsNullOrEmpty(_DT.Rows[0]["ChequeBounsDate"].ToString()))
                    _ObjChequeDetailsEntry.dtpBouncedDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["ChequeBounsDate"].ToString());

                if (_ObjChequeDetailsEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjChequeDetailsEntry.Close();
                    //Binding Grid View
                    this.GCChequeDetails.DataSource = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails();
                    this.GVChequeDetails.BestFitColumns(true);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmChequeDetails_Load(object sender, EventArgs e)
        {
            try
            {
                //Binding Grid View
                this.GCChequeDetails.DataSource = _ObjStudentFeesDetailsBLL.GetStudentFeesDetails(null,"Cheque");
                this.GVChequeDetails.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void GVChequeDetails_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
           
        }

        private void GVChequeDetails_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.GVChequeDetails.GetRowCellValue(e.RowHandle, "ChequeBounsDate").ToString()))
                {
                    e.Appearance.BackColor = System.Drawing.Color.Tomato;
                }
                else if (!string.IsNullOrEmpty(this.GVChequeDetails.GetRowCellValue(e.RowHandle, "ChequeAcceptDate").ToString()))
                {
                    e.Appearance.BackColor = System.Drawing.Color.YellowGreen;
                }
                else if (!string.IsNullOrEmpty(this.GVChequeDetails.GetRowCellValue(e.RowHandle, "ChequeRequestDate").ToString()))
                {
                    e.Appearance.BackColor = System.Drawing.Color.PaleTurquoise;
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}