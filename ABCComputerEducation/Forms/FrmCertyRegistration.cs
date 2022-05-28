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
    public partial class FrmCertyRegistration : DevExpress.XtraEditors.XtraForm
    {
        CertyRegistrationBLL _OBjCertyRegistrationBLL;
        FrmCertyRegistrationEntry _ObjCertyRegistrationEntry;
        StudentExamMarkSheetBLL _ObjStudentExamMarkSheetBLL;
        StudentMasterBLL _ObjStudentMasterBLL;
        public FrmCertyRegistration()
        {
            InitializeComponent();

            _OBjCertyRegistrationBLL = new CertyRegistrationBLL();
        }

        private void RIBEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                _ObjCertyRegistrationEntry = new FrmCertyRegistrationEntry();
                BindData(_ObjCertyRegistrationEntry);
                _ObjCertyRegistrationEntry.lblTitle.Text = "Edit Certy Registration";

                int CertyId = Convert.ToInt32(this.GVCertyRegistration.GetFocusedRowCellValue("CertyId"));
                DataTable _DT = new DataTable();
                _DT = _OBjCertyRegistrationBLL.GetCertRegistration(CertyId);
                _ObjCertyRegistrationEntry.txtCertyId.Text = _DT.Rows[0]["CertyId"].ToString();
                _ObjCertyRegistrationEntry.txtRegNo.Text = _DT.Rows[0]["RegNo"].ToString();
                _ObjCertyRegistrationEntry.ddlMarkSheetId.EditValue = _DT.Rows[0]["RefStudentExamMarkSheet_MarksheetId"].ToString();
                _ObjCertyRegistrationEntry.txtStudentName.Text = _DT.Rows[0]["StudentName"].ToString();
                _ObjCertyRegistrationEntry.ddlCertyType.EditValue = _DT.Rows[0]["CertyType"].ToString();
                if (!string.IsNullOrEmpty(_DT.Rows[0]["CertyRequestDate"].ToString()))
                    _ObjCertyRegistrationEntry.dtpRequestDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["CertyRequestDate"].ToString());
                if (!string.IsNullOrEmpty(_DT.Rows[0]["CertyReceiveDate"].ToString()))
                    _ObjCertyRegistrationEntry.dtpReceiveDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["CertyReceiveDate"].ToString());
                if (!string.IsNullOrEmpty(_DT.Rows[0]["CertyIssueDate"].ToString()))
                    _ObjCertyRegistrationEntry.dtpIssueDate.EditValue = Convert.ToDateTime(_DT.Rows[0]["CertyIssueDate"].ToString());
                if (_ObjCertyRegistrationEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjCertyRegistrationEntry.Close();
                    //Binding Data With Grid
                    this.GCCertyRegistration.DataSource = _OBjCertyRegistrationBLL.GetCertRegistration();
                    this.GVCertyRegistration.BestFitColumns(true);
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
                if (HelperCls.MsgBox("Are you sure to delete Certy Registration?", HelperCls.MessageType.Question) == DialogResult.Yes)
                {
                    int CertyId = Convert.ToInt32(this.GVCertyRegistration.GetFocusedRowCellValue("CertyId"));
                    if (_OBjCertyRegistrationBLL.DeleteRecord(CertyId, "CertyRegistration") > 0)
                    {
                        HelperCls.MsgBox("Certy Registration Detail successfully deleted!", HelperCls.MessageType.Success);
                        //Binding Data With Grid
                        this.GCCertyRegistration.DataSource = _OBjCertyRegistrationBLL.GetCertRegistration();
                        this.GVCertyRegistration.BestFitColumns(true);
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
                _ObjCertyRegistrationEntry = new FrmCertyRegistrationEntry();
                BindData(_ObjCertyRegistrationEntry);
                _ObjCertyRegistrationEntry.lblTitle.Text = "Add New Certy";

                StudentMasterBLL _ObjStudentMasterBLL = new StudentMasterBLL();
                _ObjCertyRegistrationEntry.txtCertyId.Text = "0";
                _ObjCertyRegistrationEntry.txtRegNo.Text = _ObjStudentMasterBLL.GetSequanceNo("Certy").ToString();
                //_ObjCertyRegistrationEntry.ddlMarkSheetId.EditValue = -1;
                _ObjCertyRegistrationEntry.txtStudentName.Text = "";
                _ObjCertyRegistrationEntry.ddlCertyType.EditValue = "";
                _ObjCertyRegistrationEntry.dtpRequestDate.EditValue = "";
                _ObjCertyRegistrationEntry.dtpReceiveDate.EditValue = "";
                _ObjCertyRegistrationEntry.dtpIssueDate.EditValue = "";
                if (_ObjCertyRegistrationEntry.ShowDialog() == DialogResult.OK)
                {
                    _ObjCertyRegistrationEntry.Close();
                    //Binding Data With Grid
                    this.GCCertyRegistration.DataSource = _OBjCertyRegistrationBLL.GetCertRegistration();
                    this.GVCertyRegistration.BestFitColumns(true);
                }
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        private void FrmCertyRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                if (HelperCls.UserName.ToLower().Trim() == "user")
                {
                    this.GCOLDeleteAction.Visible = false;
                }
                //Bind Grid View
                this.GCCertyRegistration.DataSource = _OBjCertyRegistrationBLL.GetCertRegistration();
                this.GVCertyRegistration.BestFitColumns(true);
            }
            catch (Exception ex)
            {
                HelperCls.MsgBox(ex.Message, HelperCls.MessageType.Error);
            }
        }

        public void BindData(FrmCertyRegistrationEntry _Obj)
        {
            try
            {
                //Get Mark Sheet Detail
                _ObjStudentExamMarkSheetBLL = new StudentExamMarkSheetBLL();
                DataTable _DTStudentMarkSheet = new DataTable();
                _DTStudentMarkSheet = _ObjStudentExamMarkSheetBLL.GetStudentExamMarkSheet();

                _Obj.ddlMarkSheetId.Properties.DataSource = _DTStudentMarkSheet;
                _Obj.ddlMarkSheetId.Properties.ValueMember = "MarkSheetId";
                _Obj.ddlMarkSheetId.Properties.DisplayMember = "MarkSheetNo";

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}