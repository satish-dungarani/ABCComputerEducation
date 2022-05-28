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
    public partial class FrmCertyRegistrationEntry : DevExpress.XtraEditors.XtraForm
    {
        CertyRegistrationBLL _ObjCertyRegistrationBLL;
        public FrmCertyRegistrationEntry()
        {
            InitializeComponent();

            _ObjCertyRegistrationBLL = new CertyRegistrationBLL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime _dtout;
                // Validations
                if (string.IsNullOrEmpty(this.ddlMarkSheetId.Text))
                {
                    HelperCls.MsgBox("Mark Sheet No Can not left blank!", HelperCls.MessageType.Warning);
                    this.ddlMarkSheetId.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(this.ddlCertyType.Text))
                {
                    HelperCls.MsgBox("Certy Type Can not left blank!", HelperCls.MessageType.Warning);
                    this.ddlCertyType.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.dtpRequestDate.Text))
                {
                    HelperCls.MsgBox("Requested Date Can not left blank!", HelperCls.MessageType.Warning);
                    this.dtpRequestDate.Focus();
                    return;
                }
                if (!DateTime.TryParse(this.dtpRequestDate.Text, out _dtout))
                {
                    HelperCls.MsgBox("Requested Date must be in date format!", HelperCls.MessageType.Warning);
                    this.dtpRequestDate.Focus();
                    return;
                }

                //Save Certy Detail
                _ObjCertyRegistrationBLL.CertyId = Convert.ToInt32(this.txtCertyId.Text);
                _ObjCertyRegistrationBLL.RegNo = this.txtRegNo.Text;
                _ObjCertyRegistrationBLL.RefStudentExamMarkSheet_MarksheetId = Convert.ToInt32(this.ddlMarkSheetId.EditValue);
                _ObjCertyRegistrationBLL.RegDate = DateTime.Now.Date;
                _ObjCertyRegistrationBLL.CertyType = Convert.ToString(this.ddlCertyType.EditValue);
                if (!string.IsNullOrEmpty(this.dtpRequestDate.Text))
                    _ObjCertyRegistrationBLL.CertyRequestDate = Convert.ToDateTime(this.dtpRequestDate.Text);
                else
                    _ObjCertyRegistrationBLL.CertyRequestDate = null;

                if (!string.IsNullOrEmpty(this.dtpReceiveDate.Text))
                    _ObjCertyRegistrationBLL.CertyReceiveDate = Convert.ToDateTime(this.dtpReceiveDate.Text);
                else
                    _ObjCertyRegistrationBLL.CertyReceiveDate = null;

                if (!string.IsNullOrEmpty(this.dtpIssueDate.Text))
                    _ObjCertyRegistrationBLL.CertyIssueDate = Convert.ToDateTime(this.dtpIssueDate.Text);
                else
                    _ObjCertyRegistrationBLL.CertyIssueDate = null;
                if (_ObjCertyRegistrationBLL.SetCertRegistration() > 0)
                {
                    if (this.txtCertyId.Text == "0")
                        HelperCls.MsgBox("Certy Registration successfully done.", HelperCls.MessageType.Success);
                    else
                        HelperCls.MsgBox("Certy Registration Detail successfully updated.", HelperCls.MessageType.Success);

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                else
                    HelperCls.MsgBox("Certy Registration detail fail to add or change.", HelperCls.MessageType.Warning);

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

        private void FrmCertyRegistrationEntry_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void ddlMarkSheetId_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.SLEV_MarkSheet.GetRowCellValue(this.SLEV_MarkSheet.FocusedRowHandle, "StudentName") != null &&
                    this.SLEV_MarkSheet.GetRowCellValue(this.SLEV_MarkSheet.FocusedRowHandle, "CourseType") != null)
                {
                    this.txtStudentName.Text = this.SLEV_MarkSheet.GetRowCellValue(this.SLEV_MarkSheet.FocusedRowHandle, "StudentName").ToString();
                    this.ddlCertyType.Text = this.SLEV_MarkSheet.GetRowCellValue(this.SLEV_MarkSheet.FocusedRowHandle, "CourseType").ToString();
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}