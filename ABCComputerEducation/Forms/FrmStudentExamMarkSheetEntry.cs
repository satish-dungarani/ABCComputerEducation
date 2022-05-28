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
using System.Globalization;

namespace ABCComputerEducation.Forms
{
    public partial class FrmStudentExamMarkSheetEntry : DevExpress.XtraEditors.XtraForm
    {
        StudentExamMarkSheetBLL _ObjStudentExamMarkSheetBLL;
        MasterValuesBLL _ObjMasterValuesBLL;
        public FrmStudentExamMarkSheetEntry()
        {
            InitializeComponent();
            _ObjMasterValuesBLL = new MasterValuesBLL();
            _ObjStudentExamMarkSheetBLL = new StudentExamMarkSheetBLL();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                decimal _decOut;
                DateTime _dtout;
                //Validation
                if (string.IsNullOrEmpty(this.txtMarkSheetNo.Text))
                {
                    HelperCls.MsgBox("Mark Sheet No can't left blank.", HelperCls.MessageType.Warning);
                    this.txtMarkSheetNo.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.ddlAdmissionId.Text))
                {
                    HelperCls.MsgBox("Admission Detail can't left blank.", HelperCls.MessageType.Warning);
                    this.ddlAdmissionId.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.dtpExamDate.Text))
                {
                    HelperCls.MsgBox("Exam Date can't left blank.", HelperCls.MessageType.Warning);
                    this.dtpExamDate.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(this.ddlExamResult.Text))
                {
                    HelperCls.MsgBox("Exam Result must be in Date format.", HelperCls.MessageType.Warning);
                    this.ddlExamResult.Focus();
                    return;
                }

                //Send Data For Store In DB
                _ObjStudentExamMarkSheetBLL.MarkSheetId= Convert.ToInt32(this.txtMarkSheetId.Text);
                _ObjStudentExamMarkSheetBLL.MarkSheetNo= this.txtMarkSheetNo.Text;
                _ObjStudentExamMarkSheetBLL.RefAdmissionMaster_AdmissionId = Convert.ToInt32(this.ddlAdmissionId.EditValue);
                _ObjStudentExamMarkSheetBLL.ExamDate= Convert.ToDateTime(this.dtpExamDate.EditValue);
                _ObjStudentExamMarkSheetBLL.ExamResult= this.ddlExamResult.Text;
                _ObjStudentExamMarkSheetBLL.User = HelperCls.User;
                _ObjStudentExamMarkSheetBLL.Terminal = HelperCls.Terminal;
                if (_ObjStudentExamMarkSheetBLL.SetStudentExamMarkSheet() > 0)
                {
                    if (this.txtMarkSheetId.Text == "0")
                        HelperCls.MsgBox("Student Exam Marksheet successfully generated.", HelperCls.MessageType.Success);
                    else
                        HelperCls.MsgBox("Student Exam MarkSheet successfully updated.", HelperCls.MessageType.Success);


                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                    HelperCls.MsgBox("Student Exam MarkSheet fail to add or change.", HelperCls.MessageType.Warning);
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
                this.txtStudentName.Text = this.SLEV_Admission.GetRowCellValue(this.SLEV_Admission.FocusedRowHandle, "StudentName").ToString();
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }
    }
}